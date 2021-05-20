using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Training_Part_3.GenericsList
{
    class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public int Basics { get; set; }

        public override string ToString()
        {
            return "EmpNo : " + EmpNo + " Name : " + Name + " Basics :" + Basics;
        }
    }
}
