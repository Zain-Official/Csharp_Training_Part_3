using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Training_Part_3.Saving_Records_With_User_Input
{
    class Get_Input
    {
        static List<Employee> employees_List;
        static Get_Input()
        {
            employees_List = new List<Employee>();
        }

        //Geting input from users
        public string AddEmploye(Employee employee)
        {
            employees_List.Add(employee);
            return "Record Save Successfullly ......";
        }


        public void ShowEmploye()
        {
            foreach(Employee e in employees_List)
            {
                Console.WriteLine("\n****************************\n");
                Console.WriteLine(e);
            }
        }

        public void AddEmployeeInput()
        {
            Employee e = new Employee();
            Console.WriteLine("Enter Employee No: ");
            e.Empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            e.Name = Console.ReadLine();
            Console.WriteLine("Enter Employe Basic Salary");
            e.Basic = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(AddEmploye(e));
        }
    }

}
