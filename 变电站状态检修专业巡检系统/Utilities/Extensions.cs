using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 变电站状态检修专业巡检系统
{
    public static class Extensions
    {
        public static int ToInt(this string str)
        {
            return int.TryParse(str, out int i) ? i : 0;
        }

        public static bool ToBool(this string str)
        {
            return "true" == str.ToLower();
        }

        public static DateTime ToDateTime(this string str)
        {
            DateTime dateTime = new DateTime();
            if (DateTime.TryParse(str, out dateTime))
            {
                return dateTime;
            }
            return default(DateTime);
        }
    }

}
