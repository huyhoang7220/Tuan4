using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(12, "Giang", DateTime.Parse("2022-09-09")));
            employees.Add(new Employee(9, "Giang", DateTime.Parse("2021-09-09")));
            employees.Add(new Employee(13, "Giang", DateTime.Parse("2020-09-09")));
            Func<List<Employee>, List<Employee>> result1 = new Func<List<Employee>, List<Employee>>(Result1);
            Console.WriteLine("Bai 1:");
            foreach (Employee e in result1(employees))
            {
                Console.WriteLine($"Id > 10: Id: {e.Id} - Name : {e.Name} - Birthday: {e.BirthDay}");
            }
        }
        public static List<Employee> Result1(List<Employee> employees)
        {
            List <Employee> result = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.Id > 10)
                    result.Add(employee);
            }
            return result;
        }
    }
}
