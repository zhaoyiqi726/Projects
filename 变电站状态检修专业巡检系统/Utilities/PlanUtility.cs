using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 变电站状态检修专业巡检系统
{
    public class PlanUtility
    {
        public static List<Plan> GetPlans()
        {
            List<Plan> list = new List<Plan>();
            var datas = SqlHelper.GetDT("SELECT * FROM t_plan");
            for (int i = 0; i < datas.Rows.Count; i++)
            {
                Plan plan = new Plan();
                plan.PlanID = datas.Rows[i]["PLAN_ID"].ToString().ToInt();
                plan.DepartmentName = datas.Rows[i]["DEPT_NAME"].ToString();
                plan.PlanName = datas.Rows[i]["NAME"].ToString();
                plan.RoutingTaskID = datas.Rows[i]["ROUTING_TASK_ID"].ToString().ToInt();
                plan.RoutingOpportunity = datas.Rows[i]["OPPORTUNITY"].ToString().ToInt();
                plan.RoutingTime = datas.Rows[i]["TIME"].ToString();
                plan.DelayAlertTimeA = datas.Rows[i]["DELAY_A"].ToString();
                plan.DelayAlertTimeB = datas.Rows[i]["DELAY_B"].ToString();
                plan.DelayedReminder = datas.Rows[i]["USERS"].ToString();
                plan.DelayAlertType = datas.Rows[i]["TYPE"].ToString();
                plan.PlanStatus = datas.Rows[i]["PLAN_STATUS"].ToString();
                plan.DepartmentID = datas.Rows[i]["DEPT_ID"].ToString().ToInt();
                plan.IsSpecialRoute = datas.Rows[i]["SPECIAL"].ToString().ToBool();
                plan.SpecialRouteID = datas.Rows[i]["SPECIAL_ID"].ToString().ToInt();
                plan.RoutingTypeID = datas.Rows[i]["ROUTING_ID"].ToString().ToInt();
                plan.Remark = datas.Rows[i]["REMARK"].ToString();
                list.Add(plan);
            }
            return list;
        }
    }
}
