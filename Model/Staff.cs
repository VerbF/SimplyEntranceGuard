using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyEntranceGuard.Control
{

    public class Staff
    {
        public String Name;
        public String CardID;
        public String ID;
        public String Dapartment;
        /// <summary>
        /// 当人员的CardID已经知道时
        /// 通过CardID在数据库中查找并设置相关信息
        /// </summary>
        public void SetInfoByCardID()
        {
            if (CardID == "201")
                Name = "张三";
            if (CardID == "242")
                Name = "李四";
        }
    }
}
