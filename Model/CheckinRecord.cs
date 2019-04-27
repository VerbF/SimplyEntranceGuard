using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyEntranceGuard.Control
{
    public class CheckinRecord : IComparable<CheckinRecord>
    {
        public string CheckinTime;
        public Staff staff;

        public CheckinRecord()
        {
            staff = new Staff();
        }
        public int CompareTo(CheckinRecord other)
        {
            int compare_result = string.Compare(this.staff.CardID, other.staff.CardID);
            if (compare_result > 0)
                return 1;
            else if (compare_result == 0)
                return 0;
            else
                return -1;
        }
    }
}
