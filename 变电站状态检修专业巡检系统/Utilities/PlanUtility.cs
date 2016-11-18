using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;

namespace 变电站状态检修专业巡检系统
{
    public class PlanUtility
    {
        public static List<Plan> GetPlans(bool IsFirstTime = true)
        {
            List<Plan> list = new List<Plan>();
            var datas = SqlHelper.GetDT("SELECT * FROM t_plan");
            for (int i = 0; i < datas.Rows.Count; i++)
            {
                Plan plan = new Plan()
                {
                    PlanID = datas.Rows[i]["PLAN_ID"].ToString().ToInt(),
                    DepartmentName = datas.Rows[i]["DEPT_NAME"].ToString(),
                    PlanName = datas.Rows[i]["NAME"].ToString(),
                    RoutingTaskID = datas.Rows[i]["ROUTING_TASK_ID"].ToString().ToInt(),
                    RoutingOpportunity = datas.Rows[i]["OPPORTUNITY"].ToString().ToInt(),
                    RoutingTime = datas.Rows[i]["TIME"].ToString(),
                    DelayAlertTimeA = datas.Rows[i]["DELAY_A"].ToString(),
                    DelayAlertTimeB = datas.Rows[i]["DELAY_B"].ToString(),
                    DelayedReminder = datas.Rows[i]["USERS"].ToString(),
                    DelayAlertType = datas.Rows[i]["TYPE"].ToString(),
                    PlanStatus = datas.Rows[i]["PLAN_STATUS"].ToString(),
                    DepartmentID = datas.Rows[i]["DEPT_ID"].ToString().ToInt(),
                    IsSpecialRoute = datas.Rows[i]["SPECIAL"].ToString().ToBool(),
                    SpecialRouteID = datas.Rows[i]["SPECIAL_ID"].ToString().ToInt(),
                    RoutingTypeID = datas.Rows[i]["ROUTING_ID"].ToString().ToInt(),
                    Remark = datas.Rows[i]["REMARK"].ToString()
                };
                list.Add(plan);
            }
            SavePlans(list);
            return list;
        }

        public static void SavePlans(List<Plan> plans)
        {

        }
    }
}
