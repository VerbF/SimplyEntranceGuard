using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyEntranceGuard.Control
{

    public class Staff
    {
        public String Name;
        public string CardID;
        public string ID;
        public string DepartmentID;
        public string DepartmentName;
        /// <summary>
        /// 当人员的CardID已经知道时
        /// 通过CardID在数据库中查找并设置相关信息
        /// </summary>
        public void SetInfoByCardID()
        {
            DatabaseUtility databaseUtility = new DatabaseUtility();

            Staff staff = databaseUtility.GetStaffByCardID(CardID);
            
            Name = staff.Name;
            ID = staff.ID;
            DepartmentID = staff.DepartmentID;
            DepartmentName = databaseUtility.GetDepartmentNameByID(DepartmentID);
            databaseUtility.CloseConnection();
        }
    }
}
