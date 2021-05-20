using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Training_Part_3.Generics
{
    class Employee
    {
        public void EmployeSwap<T>(ref T s1,ref T s2)
        {
            T t;
            t = s1;
            s1 = s2;
            s2 = t;
        }
    }
}
