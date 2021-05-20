using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Training_Part_3.Saving_Records_With_User_Input
{
    class Main_Method
    {
        static void Main(string[] args)
        {
            Get_Input gp = new Get_Input();
            int ch;
            do
            {
                Console.WriteLine("OPTIONS!");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Show Employee");
                Console.WriteLine("3. Exist");
                ch = Convert.ToInt32(Console.ReadLine());

                switch(ch)
                {
                    case 1:
                        gp.AddEmployeeInput();
                        break;
                    case 2:
                        gp.ShowEmploye();
                        break;
                    default :
                        Console.WriteLine("Invalid Choice.....");
                        break;
                }


            } while (ch != 3);

        }
    }
}
