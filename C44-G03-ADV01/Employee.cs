using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_ADV01
{
    internal class Employee
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

        public override bool Equals(object? obj)
        {
            Employee? employee = (Employee?)obj;

            if(employee is not null)
            {
                return ((this.Id == employee.Id) && (this.Name == employee.Name) && (this.Salary == employee.Salary));
            }

            return false;
        }

        public override int GetHashCode()
        {
            //return Id.GetHashCode() + (Name?.GetHashCode() ?? 0) + Salary.GetHashCode();
            return HashCode.Combine(Id, Name, Salary);
        }
      
    }
}
