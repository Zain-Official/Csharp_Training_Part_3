using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Training_Part_3.GenericsList
{
    class EmployeeList
    {
        public void ShowEmploye()
        {
            List<Employee> employees_list = new List<Employee>()
            {
                new Employee{EmpNo=101,Name="Zain Sindhi",Basics=7999},
                 new Employee{EmpNo=102,Name="Haseeb",Basics=7999},
                  new Employee{EmpNo=103,Name="Hafeez",Basics=5000},
                   new Employee{EmpNo=104,Name="Baloo",Basics=9000},
                    new Employee{EmpNo=105,Name="Maroof",Basics=4500},
            };

            Console.WriteLine("Employe List Is");
            foreach(Employee e in employees_list)
            {
                Console.WriteLine(e);
            }
            
        }
    }
}
