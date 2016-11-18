using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 变电站状态检修专业巡检系统
{
    public class DepartmentUtility
    {
        public static List<Department> GetDepartments()
        {
            List<Department> list = new List<Department>();
            var datas = SqlHelper.GetDT("SELECT * FROM t_sys_dept");
            for (int i = 0; i < datas.Rows.Count; i++)
            {
                Department department = new Department()
                {
                    DepartmentID = int.Parse(datas.Rows[i]["DEPT_ID"].ToString()),
                    ParentDepartmentID = int.Parse(datas.Rows[i]["P_ID"].ToString()),
                    DepartmentName = datas.Rows[i]["DEPT_NAME"].ToString(),
                    Longitude = double.Parse(datas.Rows[i]["LNG"].ToString()),
                    Latitude = double.Parse(datas.Rows[i]["LAT"].ToString()),
                    Description = datas.Rows[i]["DESCRIPTION"].ToString(),
                    DepartmentNo = datas.Rows[i]["DEPT_NO"].ToString(),
                    DepartmentLeader = datas.Rows[i]["DEPT_LEADER"].ToString()
                };
                list.Add(department);
            }
            return list;
        }

        public static List<Department> BindDepartment(List<Department> departments)
        {
            List<Department> bindDepartments = new List<Department>();
            for (int i = 0; i < departments.Count; i++)
            {
                if (0 == departments[i].ParentDepartmentID)
                {
                    bindDepartments.Add(departments[i]);
                }
                else
                {
                    FindDownward(departments, departments[i].ParentDepartmentID).Departments.Add(departments[i]);
                }
            }
            return bindDepartments;
        }

        private static Department FindDownward(List<Department> departments, int id)
        {
            if (null == departments)
                return null;
            for (int i = 0; i < departments.Count; i++)
            {
                if (id == departments[i].DepartmentID)
                {
                    return departments[i];
                }
                Department department = FindDownward(departments[i].Departments, id);
                if (null != department)
                {
                    return department;
                }
            }
            return null;
        }
    }
}
