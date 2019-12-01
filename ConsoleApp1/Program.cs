using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        List<int> varsA = new List<int>();
        List<int> varsB = new List<int>();
        List<int> desc = new List<int>();
        
        static void Main(string[] args)
        {
            Program Rechenprogramm = new Program();
            Rechenprogramm.Menu();
        }
        private int Addition(int a, int b)
        {
            return a + b;
        }
        private int Minus(int a, int b)
        {
            return a - b;
        }
        private int Multiplication(int a, int b)
        {
            return a * b;
        }
        private int Division(int a, int b)
        {
            return a / b;
        }
        private int Mudolu(int a, int b)
        {
            return a % b;
        }

        private int HistoryChoice(int choice, int a, int b)
        {
            int c = 0;
            switch (choice)
            {
                case 1:
                    c = Addition(a, b);
                    return c;

                case 2:
                    c = Minus(a, b);
                    return c;

                case 3:
                    c = Multiplication(a, b);
                    return c;

                case 4:
                    c = Division(a, b);
                    return c;

                case 5:
                    c = Mudolu(a, b);
                    return c;

                default:
                    return 0;


            }
        }

        public void ReturnMem()
        {
            Console.WriteLine("Content of last saved variables: \n{");
            for (int i = 0; i < varsA.Count; i++)
            {
                Console.WriteLine("({0},{1}, Descision: {2}, Result: {3})", varsA[i], varsB[i], desc[i], HistoryChoice(desc[i], varsA[i], varsB[i]));
                if (i < varsA.Count)
                {
                    Console.WriteLine("}\n");
                }
                else
                {
                    Console.WriteLine(",\n");
                }
            }
            
        }
        public void DecisionMaking(int a, int b, int d)
        {
            switch (d)
            {
                case 1:
                    c = Addition(a, b);
                    Console.WriteLine("Hello World! {0} plus {1} = {2}", a, b, Addition(a, b));
                    Menu();
                    break;
                case 2:
                    c = Minus(a, b);
                    Console.WriteLine("Hello World! {0} minus {1} = {2}", a, b, Minus(a, b));
                    Menu();
                    break;
                case 3:
                    c = Multiplication(a, b);
                    Console.WriteLine("Hello World! {0} multiply {1} = {2}", a, b, Multiplication(a, b));
                    Menu();
                    break;
                case 4:
                    c = Division(a, b);
                    Console.WriteLine("Hello World! {0} division {1} = {2}", a, b, Division(a, b));
                    Menu();
                    break;
                case 5:
                    c = Mudolu(a, b);
                    Console.WriteLine("Hello World! {0} mode {1} = {2}", a, b, Mudolu(a, b));
                    Menu();
                    break;
                case 6:
                    ReturnMem();
                    Menu();
                    break;
                case 8:
                    Console.WriteLine("Recall of values from memory. \n");
                    if (desc.Count < 0)
                    {
                        ReturnMem();
                        Console.WriteLine("Please provide the index of a position: ");
                        string i = Console.ReadLine();
                        var_i = Convert.ToInt32(i);
                        Console.WriteLine("Calling %0, " );


                    }

                    break;
                default:
                    Environment.Exit(-1); break;
            }
        }

        public int ReadD(String d)
        {
            Console.WriteLine("Please select your programm mode\n *1 for plus (+)\n *2 for minus (-)\n *3 for multiplication (*)\n *4 for division (/)\n *5 for modulo (%)\n*6 for history");
            d = Console.ReadLine();
            int val_decision = Convert.ToInt32(d);
            desc.Add(val_decision);

            return val_decision;
        }


        public void Menu()
        {
            string a;
            string b;
            int c;
            string i;
            string decision;
            int val_a = 0;
            int val_b = 0;
            int var_i = 0;

            if (ReadD(decision) < 6 )
            {
                Console.WriteLine("Please select your first variable");
                a = Console.ReadLine();

                val_a = Convert.ToInt32(a);
                varsA.Add(val_a);
                Console.WriteLine("Please select your first variable");
                b = Console.ReadLine();
                val_b = Convert.ToInt32(b);
                varsB.Add(val_b);
            }
            DecisionMaking(val_a, val_b, var_decision);
            
        }
        
    }
}
