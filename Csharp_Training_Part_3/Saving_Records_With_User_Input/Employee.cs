using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Training_Part_3.Saving_Records_With_User_Input
{
    class Employee
    {
        public int Empno { get; set; }
        public string Name { get; set; }
        public int Basic { get; set; }

        public override string ToString()
        {
            return "Employe No : " + Empno + "\nEmploye Name : " + Name + "\n Employe Basic : " + Basic;
        }
    }
}
