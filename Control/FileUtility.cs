using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplyEntranceGuard.Control
{
    public class FileUtility
    {
        public static int SINGE_CHECKIN_RECORD_LENGTH = 11;
        public static int CARDID_LENGTH = 3;
        public static int CHECKIN_TIME_LENGTH = 8;
        public string file_name;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="FileName"></param>
        public FileUtility(String FileName)
        {
            file_name = FileName;
        }
        public FileUtility()
        {

        }
        /// <summary>
        /// 读取文件内容
        /// </summary>
        /// <returns></returns>
        public string ReadFile()
        {
            string result;
            StreamReader sr = new StreamReader(Application.StartupPath + "\\" + file_name, false);
            result = sr.ReadLine().ToString();
            sr.Close();
            return result;
        }        
        public List<CheckinRecord> GetNewCheckinRecord()
        {
            List<CheckinRecord> records = new List<CheckinRecord>();
            int length = GetLength();

            int record_count = length / SINGE_CHECKIN_RECORD_LENGTH;
            string file_content = ReadFile();
            for(int position = 0; position < record_count * SINGE_CHECKIN_RECORD_LENGTH;)
            {
                CheckinRecord record = new CheckinRecord();
                Staff staff = new Staff();
                staff.CardID = file_content.Substring(position,CARDID_LENGTH);
                position += CARDID_LENGTH;
                record.CheckinTime = file_content.Substring(position, CHECKIN_TIME_LENGTH);
                position += CHECKIN_TIME_LENGTH;
                staff.SetInfoByCardID();
                record.staff = staff;
                records.Add(record);
            }
            return records;
        }
        /// <summary>
        /// 获得文件内容长度
        /// </summary>
        /// <returns></returns>
        public int GetLength()
        {
            int newLength = ReadFile().Length;
            return newLength;
        }
    }
}
