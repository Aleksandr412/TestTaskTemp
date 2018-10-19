using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskKosta
{
    public class Department : Employee
    {
        public string DeptID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string ParentDepartmentID { get; set; }

        public string GetOrgStructure
        {
            get
            {
                return $"{Name} - {Position}";
            }
        }

        public string GetDepartmentName
        {
            get
            {
                return $"{Name}";
            }
        }
    }
}
