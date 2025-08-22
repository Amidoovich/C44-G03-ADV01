using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_ADV01
{
    internal class EmployeeAgeComperer : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return x?.Age.CompareTo(y?.Age) ?? -1;
        }
    }
}
