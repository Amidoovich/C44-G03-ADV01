using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_ADV01
{
    internal struct Employee
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public Employee(int id, string? name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public static bool operator ==(Employee left, Employee right)
        {
            //return ((left.Id == right.Id) && (left.Name == right.Name) && (left.Salary == right.Salary));
            return left.Equals(right);
        }
        public static bool operator !=(Employee left, Employee right)
        {
            //return ((left.Id != right.Id) || (left.Name != right.Name) || (left.Salary != right.Salary));
            return !left.Equals(right);
        }
      
    }
}
