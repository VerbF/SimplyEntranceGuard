using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Data;

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
                staff.Dapartment = row["department_id"].ToString();
                staffs.Add(staff);
            }

            return staffs;
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
        /// 关闭与数据库的连接
        /// </summary>
        public void CloseConnection()
        {
            connection.Close();
        }
    }
}
