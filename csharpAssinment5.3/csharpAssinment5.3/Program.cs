using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace OopsCsharpAssignment2
{
    internal class Employee
    {



        public int ID { get; set; }
        public string Name;
        public double Salary;
        public static int EmployeeCount = 0;
        internal bool getname;



        //emp has to define date of joining



        //default constructor
        public Employee()
        {
            ID = 0;
            Name = "";
            Salary = 0.0;
            EmployeeCount += 1;
        }
        //Parameterized constructor
        public Employee(int id, string name, double salary)
        {
            this.ID = id;
            this.Name = name;
            this.Salary = salary;
            EmployeeCount += 1;
        }
        public override string ToString()
        {
            return "\nEmployee Id = " + ID + "\nEmployee Name = " + Name + "\nBasic Salary = " + Salary+"\nNo of Employee:" + EmployeeCount;
        }



        //Salary calculation 
        public virtual double CalculateSalary()
        {
            return Salary;
        }
      
    }
  

        class Program
        {
            public static void Main()
            {
                Employee emp = new Employee(100, "bithi", 20000);
                LinkedList<Employee> list = new LinkedList<Employee>();
                list.AddFirst(emp);
                // list.AddLast(emp1);
                foreach (Employee res in list)
                {
                    Console.WriteLine(res);
                }


                Console.WriteLine("Enter the name to search the employee details:\n");

                string searchName = Console.ReadLine();
                bool found = false;

                foreach (Employee e in list)
                {
                    if (e.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                    {
                        found = true;
                    }
                    else
                    {
                        found = false;
                    }
                }
                Console.WriteLine(found == true ? "Employee found." : "No record found.");


            }
        }
    }