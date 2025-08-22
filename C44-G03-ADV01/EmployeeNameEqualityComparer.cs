using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_ADV01
{
    internal class EmployeeNameEqualityComparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            return x?.Name == y?.Name;
        }
        public int GetHashCode(Employee obj)
        {
            return HashCode.Combine(obj.Name);
        }
    }
}
 