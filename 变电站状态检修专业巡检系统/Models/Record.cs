using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 变电站状态检修专业巡检系统
{
    public class Record
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int RecordID { get; set; }

        /// <summary>
        /// 巡检时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 巡检类别
        /// </summary>
        public int RoutingType { get; set; }

        /// <summary>
        /// 天气
        /// </summary>
        public string Weather { get; set; }

        /// <summary>
        /// 温度
        /// </summary>
        public string Temperature { get; set; }

        /// <summary>
        /// 任务管理编号
        /// </summary>
        public int PlanID { get; set; }

        /// <summary>
        /// 巡检计划
        /// </summary>
        public string PlanName { get; set; }

        /// <summary>
        /// 巡检人员
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 站长
        /// </summary>
        public string Leader { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 巡检区域
        /// </summary>
        public string DepartmentName { get; set; }

        /// <summary>
        /// 组织编号
        /// </summary>
        public int DepartmentID { get; set; }

        /// <summary>
        /// 巡检记录编号
        /// </summary>
        public string RecordNo { get; set; }

        /// <summary>
        /// 是否特殊巡检
        /// </summary>
        public bool IsSpecial { get; set; }

        /// <summary>
        /// 完成否
        /// </summary>
        public string Finish { get; set; }
    }
}
