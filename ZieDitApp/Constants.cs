using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZieDitApp
{
    public class Constants
    {
        //Api
        public const string GET_HOLIDAY = "https://calendarific.com/api/v2/holidays?&api_key=23CIsrHnhdAhCFJhAXk3WFyAWvFYpQCT&country=NL&year={0}";
        //Database
        private const string DBFileName = "ziedit.db3";
        public const SQLiteOpenFlags flags =
            SQLiteOpenFlags.ReadWrite |
            SQLiteOpenFlags.Create |
            SQLiteOpenFlags.SharedCache;

        public static string DatabasePath
        {
            get
            {
                return Path.Combine(FileSystem.AppDataDirectory, DBFileName);
            }
        }
    }
}
