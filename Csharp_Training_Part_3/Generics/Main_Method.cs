using System;

namespace Csharp_Training_Part_3.Generics
{
    class Main_Method
    {
        static void Main(string[] args)
        { 
            int a = 12;
            int b = 34;
            Sweap s = new Sweap();
            s.swap(ref a, ref b);
            Console.WriteLine("The Value of a = " + a + "\nValue of b = " + b);



            Console.WriteLine("\n************With Generics************\n");
            double d1 = 12.5;
            double d2 = 7.9;
            s.swap(ref d1,ref d2);
            Console.WriteLine("The Value of a = " + d1 + "\nValue of b = " + d2);


            Console.WriteLine("\n************************\n");
            int x = 2;
            int y = 4;
            GenSweap gs = new GenSweap();
            gs.S_NO(ref x, ref y);
            Console.WriteLine("The Value of a = " + x + "\nValue of b = " + y);



            Console.WriteLine("\n************With Generics************\n");
            double d11 = 2.1;
            double d22 = 1.1;
            gs.S_NO(ref d11, ref d22);
            Console.WriteLine("The Value of a = " + d11 + "\nValue of b = " + d22);



            Console.WriteLine("\n************String With Generics************\n");
            string s1 = "Zain Sindhi";
            string s2 = "Haseeb";         
            Employee e = new Employee();
            e.EmployeSwap(ref s1, ref s2);

            Console.WriteLine("The Value of a = " + s1 + "\nValue of b = " + s2);


            Console.WriteLine("\n************String With Generics************\n");
            employe2 e1 = new employe2();
            e1.Empno = 786;
            e1.Name = "Mehtab Mashori";
            e1.Basics = 12000;

            employe2 e2 = new employe2();
            e2.Empno = 110;
            e2.Name = "Azhar lala";
            e2.Basics = 14000;

            e.EmployeSwap(ref e1, ref e2);

            Console.WriteLine("First Object = "+e1+"\nSecond Object = "+e2);

            

        }
    }
}
