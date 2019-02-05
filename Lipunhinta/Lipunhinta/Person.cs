using System;
using System.Collections.Generic;
using System.Text;

namespace Lipunhinta
{
    class Person
    {
        private int _age = -1;
        public bool conscript = false;
        public bool mtk = false;
        public bool student = false;

        public int Age
        {
            get { return _age;  }
            set
            {
                if(value < 0 || value > 100)
                {
                    Console.WriteLine("Väärä syöte! Iän täytyy olla väliltä 0-100.");
                }
                else
                {
                    _age = value;
                }
            }
        }

        public Person()
        {
            _age = -1;

        }

        public void AskConscript()
        {
            do
            {
                Console.WriteLine("Oletko varusmies? K/E");
                var input = Console.ReadKey();
                if(input.Key == ConsoleKey.K)
                {
                    conscript = true;
                    break;
                }

                else if (input.Key == ConsoleKey.E)
                {
                    conscript = false;
                    break;
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Teeppä kuule niinkun sanotaan, ja laita K tai E.");
                }
            }
            while (true);
        }

        public void AskStudent()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Oletko opiskelija? (K/E)");
                var input = Console.ReadKey();
                if (input.Key == ConsoleKey.K)
                {
                    student = true;
                    break;
                }

                else if (input.Key == ConsoleKey.E)
                {
                    student = false;
                    break;
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Teeppä kuule niinkun sanotaan, ja laita K tai E.");
                }
            }
            while (true);
        }

        public void AskMTK()
        {
            Console.Clear();
            do
            {
                Console.WriteLine("Oletko MTK:n jäsen? (K/E)");
                var input = Console.ReadKey();
                if (input.Key == ConsoleKey.K)
                {
                    mtk = true;
                    break;
                }

                else if (input.Key == ConsoleKey.E)
                {
                    mtk = false;
                    break;
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Teeppä kuule niinkun sanotaan, ja laita K tai E.");
                }
            }
            while (true);
        }

        public void Print()
        {

        }
    }
}
