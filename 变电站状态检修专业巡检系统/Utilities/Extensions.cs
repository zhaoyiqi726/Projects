using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 变电站状态检修专业巡检系统.Utilities
{
    public static class Extensions
    {
        public static int ToInt(this string str)
        {
            int i = 0;
            if (int.TryParse(str, out i))
            {
                return i;
            }
            return 0;
        }
    }
}
