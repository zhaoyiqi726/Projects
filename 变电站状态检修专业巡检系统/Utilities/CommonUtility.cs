using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace 变电站状态检修专业巡检系统
{
    public class CommonUtility
    {
        public static string GenerateMD5(string str)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(str);
            byte[] hashBytes = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }


        public static string[] GetLocalUserName()
        {
            return ConfigurationManager.AppSettings["UserName"].ToString().Split(';');
        }

        public static void SaveUserName(string userName)
        {
            var userNames = ConfigurationManager.AppSettings["UserName"].ToString().Split(';');
            foreach (var name in userNames)
            {
                if (userName == name.ToString())
                {
                    return;
                }
            }

            Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            cfa.AppSettings.Settings["UserName"].Value += $";{userName}";
            cfa.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
