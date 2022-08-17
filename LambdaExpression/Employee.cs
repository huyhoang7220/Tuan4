using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaExpression
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public Employee(int id, string name, DateTime birthDay)
        {
            Id = id;
            Name = name;
            BirthDay = birthDay;
        }
    }
}
