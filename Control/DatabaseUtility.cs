﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace SimplyEntranceGuard.Control
{
    public class DatabaseUtility
    {
        static string ID = "root";
        static string PASSWORD = "704865074";
        static string IP_ADDRESS = "127.0.0.1";
        static string DATABASE_NAME = "SimplyEntranceGuard";
        static string PORT = "3306";
        static string CHARSET = "utf8";
        public MySqlConnection connection;
        public  DatabaseUtility()
        {
            string ConString = "Server="+IP_ADDRESS+";Database="+DATABASE_NAME+"; User ID=" + ID + ";Password="+ PASSWORD+";port="+PORT+";CharSet="+CHARSET+";pooling=true;";
            connection = new MySqlConnection(ConString);//连接数据库
            connection.Open();//打开连接            
        }
        /// <summary>
        /// 获得全部人员数据
        /// </summary>
        /// <returns></returns>
        public List<Staff> GetAllStaffs()
        {
            List<Staff> staffs = new List<Staff>();

            string cmd_str = "select *  from staff ";//sql语句
            DataTable dataTable = SelectSql(cmd_str);//执行sql语句，获得返回结果
            foreach (DataRow row in dataTable.Rows )
            {

                Staff staff = new Staff();
                staff.CardID = row["card_id"].ToString();
                staff.Name = row["name"].ToString();
                staff.DepartmentID = row["department_id"].ToString();
                staff.DepartmentName = GetDepartmentNameByID(staff.DepartmentID);
                staffs.Add(staff);
            }

            return staffs;
        }
        /// <summary>
        /// 获得全部考勤信息
        /// </summary>
        /// <returns></returns>
        public List<CheckinRecord> GetAllRecords()
        {
            List<CheckinRecord> records = new List<CheckinRecord>();

            string cmd_str = "SELECT checkin_time, " +
            "checkin_record.card_id as card_id, " +
            "department.name as department_name," +
            "staff.`name` as staff_name " +
            "FROM checkin_record, staff, department " +
            "where staff.card_id = checkin_record.card_id and staff.department_id = department.id";//sql语句
            DataTable dataTable = SelectSql(cmd_str);//执行sql语句，获得返回结果
            foreach (DataRow row in dataTable.Rows)
            {

                CheckinRecord record = new CheckinRecord();
                record.CheckinTime = row["checkin_time"].ToString();
                record.staff.CardID = row["card_id"].ToString();
                record.staff.DepartmentName = row["department_name"].ToString();
                record.staff.Name = row["staff_name"].ToString();
                records.Add(record);
            }

            return records;
        }
        /// <summary>
        /// 执行 select sql 语句 并返回结果
        /// </summary>
        /// <param name="cmd_str"></param>
        /// <returns></returns>
        public DataTable SelectSql(string cmd_str)
        {
            
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd_str, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            DataTable dataTable = dataSet.Tables[0];
            return dataTable;
        }
        /// <summary>
        /// 通过card_id 获取 人员信息
        /// </summary>
        /// <param name="card_id"></param>
        /// <returns></returns>
        public Staff GetStaffByCardID(string card_id)
        {
            Staff staff = new Staff();

            DataTable dataTable = new DataTable();

            string sql_str = "select * from staff where card_id = '" + card_id + "'";
            dataTable = SelectSql(sql_str);
            DataRow row;
            try
            {
                row = dataTable.Rows[0];
            }
            catch (Exception)
            {
                MessageBox.Show("考勤记录有误请重试！");
                throw;
            }
            

            staff.CardID = row["card_id"].ToString();
            staff.Name = row["name"].ToString();
            staff.DepartmentID = row["department_id"].ToString();

            return staff;
        }
        /// <summary>
        /// 通过部门id获得部门名称
        /// </summary>
        /// <param name="department_id"></param>
        /// <returns></returns>
        public string GetDepartmentNameByID(string department_id)
        {
            string department_name;

            DataTable dataTable = new DataTable();
            string sql_str = "select * from department where id = '" + department_id + "'";
            dataTable = SelectSql(sql_str);
            DataRow row = dataTable.Rows[0];

            department_name = row["name"].ToString();

            return department_name;

        }
        /// <summary>
        /// 更新语句
        /// </summary>
        /// <param name="sql_str"></param>
        /// <returns></returns>
        public bool UpdateSql(string sql_str)
        {
            bool isSuccess = false;
            MySqlCommand cmd = new MySqlCommand(sql_str,connection);

            int result_count = cmd.ExecuteNonQuery();
            if (result_count != 0)
                isSuccess = true;
            return isSuccess;
        }
        /// <summary>
        /// 插入语句
        /// </summary>
        /// <param name="sql_str"></param>
        /// <returns></returns>
        public bool InsertSql(string sql_str)
        {
            bool isSuccess = false;
            MySqlCommand cmd = new MySqlCommand(sql_str, connection);

            int result_count = cmd.ExecuteNonQuery();
            if (result_count != 0)
                isSuccess = true;
            return isSuccess;
        }
        /// <summary>
        /// 关闭与数据库的连接
        /// </summary>
        public void CloseConnection()
        {
            connection.Close();
        }
    }
}
