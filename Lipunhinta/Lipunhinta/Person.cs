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
                    Console.WriteLine("iän täytyy olla väliltä 0-100.");
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

        public void Print()
        {
            Console.WriteLine(_age);
        }
    }
}
