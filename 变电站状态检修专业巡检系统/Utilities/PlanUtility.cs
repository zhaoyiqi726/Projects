using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 变电站状态检修专业巡检系统.Utilities
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

                list.Add(plan);
            }
            return list;
        }
    }
}
