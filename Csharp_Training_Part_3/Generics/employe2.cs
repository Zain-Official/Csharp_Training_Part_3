using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Training_Part_3.Generics
{
    class employe2
    {
        public int Empno { get; set; }
        public string Name { get; set; }
        public double Basics { get; set; }

        public override string ToString()
        {
            return "Employe No : " + Empno + " Name : " + Name + " Basics : " + Basics;
        }

    }


    }
