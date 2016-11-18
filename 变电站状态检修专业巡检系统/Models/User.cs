using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 变电站状态检修专业巡检系统
{
    public class User
    {
        /// <summary>
        /// 用户编号
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// 用户帐号
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 真实姓名
        /// </summary>
        public string RealName { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// 职务
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 用户角色
        /// </summary>
        public string UserRoleName { get; set; }

        /// <summary>
        /// 用户密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 上次巡检时间
        /// </summary>
        public DateTime LastInspectionTime { get; set; }
        
        /// <summary>
        /// 组织ID
        /// </summary>
        public int DepartmentID { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public string HeadIcon { get; set; }
    }
}
