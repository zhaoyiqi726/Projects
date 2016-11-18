using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace 变电站状态检修专业巡检系统
{
    public class RecordUtility
    {
        public static Record GetRecord(int planID)
        {
            Record record = new Record();
            var datas = SqlHelper.GetDT("SELECT * FROM t_routing_record WHERE PLAN_ID = @PlanID",
                new MySqlParameter("@PlanID", planID)).Rows[0];
            record.RecordID = datas["ROUTING_RECORD_ID"].ToString().ToInt();
            record.CreateTime = datas["CREATE_TIME"].ToString().ToDateTime();
            record.RoutingType = datas["TYPE"].ToString().ToInt();
            record.Weather = datas["WEATHER"].ToString();
            record.Temperature = datas["TEMPERATURE"].ToString();
            record.PlanID = datas["PLAN_ID"].ToString().ToInt();
            record.PlanName = datas["ROUTING_PLAN_NAME"].ToString();
            record.UserName = datas["USERNAME"].ToString();
            record.Leader = datas["LEADER"].ToString();
            record.Remark = datas["REMARK"].ToString();
            record.DepartmentName = datas["DEPT_NAME"].ToString();
            record.DepartmentID = datas["DEPT_ID"].ToString().ToInt();
            record.RecordNo = datas["ROUTING_RECORD_NO"].ToString();
            record.IsSpecial = "1" == datas["SPECIAL"].ToString();
            record.Finish = datas["FINISH"].ToString();
            return record;
        }
    }
}
