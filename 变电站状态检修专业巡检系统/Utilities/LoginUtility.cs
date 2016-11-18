using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace 变电站状态检修专业巡检系统
{
    public class LoginUtility
    {
        public static bool CheckPassword(string userName, string password)
        {
            return "0" != SqlHelper.GetScalar("SELECT COUNT(*) FROM t_sys_user WHERE USERNAME=@UserName AND PASSWORD=@Password",
                new MySqlParameter("@UserName", userName),
                new MySqlParameter("@Password", CommonUtility.GenerateMD5(password))).ToString();
        }

        public static User GetUser(string userName)
        {
            User user = new User();
            var datas = SqlHelper.GetDT("SELECT * FROM t_sys_user WHERE USERNAME=@UserName",
                new MySqlParameter("@UserName", userName));
            user.UserID = datas.Rows[0]["USER_ID"].ToString().ToInt();
            user.UserName = datas.Rows[0]["USERNAME"].ToString();
            user.RealName = datas.Rows[0]["REAL_NAME"].ToString();
            user.Sex = datas.Rows[0]["SEX"].ToString();
            user.Position = datas.Rows[0]["POSITION"].ToString();
            user.Phone = datas.Rows[0]["PHONE"].ToString();
            user.Remark = datas.Rows[0]["REMARK"].ToString();
            user.UserRoleName = datas.Rows[0]["USER_ROLE_NAME"].ToString();
            user.Password = datas.Rows[0]["PASSWORD"].ToString();
            user.LastInspectionTime = datas.Rows[0]["LAST_INSPECTION_TIME"].ToString().ToDateTime();
            user.DepartmentID = datas.Rows[0]["DEPT_ID"].ToString().ToInt();
            user.HeadIcon = datas.Rows[0]["HEAD_ICONS"].ToString();
            return user;
        }

        public static List<string> GetUsers(bool isLeader = true)
        {
            var users = new List<string>();
            DataTable datas;
            if (isLeader)
            {
                datas = SqlHelper.GetDT("SELECT REAL_NAME FROM t_sys_user WHERE POSITION LIKE '%长'");
            }
            else
            {
                datas = SqlHelper.GetDT("SELECT REAL_NAME FROM t_sys_user WHERE POSITION LIKE '运行人员'");
            }
            for (int i = 0; i < datas.Rows.Count; i++)
            {
                users.Add(datas.Rows[i][0].ToString());
            }
            return users;
        }
    }
}
