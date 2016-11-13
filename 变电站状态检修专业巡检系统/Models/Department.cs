using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 变电站状态检修专业巡检系统
{
    public class Department
    {
        public Department()
        {
            Departments = new List<Department>();
        }
        /// <summary>
        /// 部门编号
        /// </summary>
        public int DepartmentID { get; set; }

        /// <summary>
        /// 上级部门编号
        /// </summary>
        public int ParentDepartmentID { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        public string DepartmentName { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        public double Longitude { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        public double Latitude { get; set; }

        /// <summary>
        /// 部门描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 组织编号
        /// </summary>
        public string DepartmentNo { get; set; }

        /// <summary>
        /// 部门领导
        /// </summary>
        public string DepartmentLeader { get; set; }

        /// <summary>
        /// 子部门
        /// </summary>
        public List<Department> Departments { get; set; }
    }
}
