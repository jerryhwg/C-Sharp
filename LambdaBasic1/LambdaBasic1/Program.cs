﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaBasic1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Employee employee = new Employee();
            List<Employee> empList = new List<Employee>()
            {
                new Employee { FName = "Bill", LName = "Gates", Id = 101 },
                new Employee { FName = "Steve", LName = "Jobs", Id = 102 },
                new Employee { FName = "Jeff", LName = "Bezos", Id = 103 },
                new Employee { FName = "Joe", LName = "Mara", Id = 104 },
                new Employee { FName = "Joe", LName = "Wang", Id = 105 },
                new Employee { FName = "Steven", LName = "Holmes", Id = 106 },
                new Employee { FName = "Mark", LName = "Zerkburg", Id = 107 },
                new Employee { FName = "Larry", LName = "Page", Id = 108 },
                new Employee { FName = "Tim", LName = "Cook", Id = 109 },
                new Employee { FName = "Jerry", LName = "Lee", Id = 110 }
            };
            List<Employee> empListJoe = new List<Employee>();
            // int counter = 0;
            foreach (Employee employee in empList)
            {
                if (employee.FName == "Joe")
                {
                    empListJoe.Add(employee);
                    // counter++;
                    // Console.WriteLine($"Employee Name: {employee.FName} {employee.LName}, Employee ID: {employee.Id}");
                }
            }

            foreach (Employee employee in empListJoe)

            {
                Console.WriteLine($"{employee.FName} {employee.LName} {employee.Id}");
            }

            // Console.WriteLine(counter);

            //Console.WriteLine(String.Join(" \n", empListJoe));
            Console.ReadLine();
        }
    }
    public class Employee
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public int Id { get; set; }

        //public override string ToString()
        //{
        //    return $"Name: {FName} {LName}, Id: {Id}";
        //}
    }
}
