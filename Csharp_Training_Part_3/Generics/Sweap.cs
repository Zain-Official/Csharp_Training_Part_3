using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Training_Part_3.Generics
{
    class Sweap
    {
        public void swap <T>(ref T a,ref T b)
        {
            T t;
            t = a;
            a = b;
            b = t;

        }
    }
}
