using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            string b;
            int c;
            string decision;
            
            Console.WriteLine("Please select your first variable");
            a = Console.ReadLine();
            int val_a = Convert.ToInt32(a);
            Console.WriteLine("Please select your first variable");
            b = Console.ReadLine();
            int val_b = Convert.ToInt32(b);
            Console.WriteLine("Please select your programm mode");
            decision = Console.ReadLine();
            int val_decision = Convert.ToInt32(decision);
            switch (val_decision)
            {
                case 1: c = val_a + val_b;
                    Console.WriteLine("Hello World! {0} plus {1} = {2}", a, b, c);break;
                case 2:
                    c = val_a - val_b; ;
                    Console.WriteLine("Hello World! {0} minus {1} = {2}", a, b, c); break;
                case 3:
                    c = val_a * val_b; ;
                    Console.WriteLine("Hello World! {0} multiply {1} = {2}", a, b, c); break;
                case 4:
                    c = val_a / val_b; ;
                    Console.WriteLine("Hello World! {0} division {1} = {2}", a, b, c); break;
                case 5:
                    c = val_a % val_b; ;
                    Console.WriteLine("Hello World! {0} mode {1} = {2}", a, b, c); break;
            }

        }
    }
}
