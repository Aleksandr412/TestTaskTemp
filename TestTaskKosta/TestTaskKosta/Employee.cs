using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskKosta
{
    public class Employee
    {
        public int EmplID { get; set; }

        public string FirstName { get; set; }

        public string SurName { get; set; }

        public string Patronymic { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string DocSeries { get; set; }

        public string DocNumber { get; set; }

        public string Position { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{ FirstName} {SurName} ({Position})";
            }
        }

    }
}
