using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 变电站状态检修专业巡检系统
{
    public class Plan
    {
        /// <summary>
        /// 计划编号
        /// </summary>
        public int PlanID { get; set; }

        /// <summary>
        /// 所属机构
        /// </summary>
        public string DepartmentName { get; set; }

        /// <summary>
        /// 巡检计划名称
        /// </summary>
        public string PlanName { get; set; }

        /// <summary>
        /// 巡检任务
        /// </summary>
        public int RoutingTaskID { get; set; }

        /// <summary>
        /// 巡检时机
        /// </summary>
        public int RoutingOpportunity { get; set; }

        /// <summary>
        /// 巡检时间
        /// </summary>
        public string RoutingTime { get; set; }

        /// <summary>
        /// 延迟提醒A
        /// </summary>
        public string DelayTimeA { get; set; }

        /// <summary>
        /// 延迟提醒B
        /// </summary>
        public string DelayTimeB { get; set; }

        /// <summary>
        /// 提醒人
        /// </summary>
        public string DelayUser { get; set; }

        /// <summary>
        /// 提醒方式
        /// </summary>
        public char DelayType { get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        public char PlanStatus { get; set; }

        /// <summary>
        /// 所属机构编号
        /// </summary>
        public int DepartmentID { get; set; }

        /// <summary>
        /// 是否特殊巡检
        /// </summary>
        public bool IsSpecialRoute { get; set; }

        /// <summary>
        /// 特殊巡检ID
        /// </summary>
        public int SpecialRouteID { get; set; }

        /// <summary>
        /// 巡检类别ID
        /// </summary>
        public int RoutingTypeID { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}
