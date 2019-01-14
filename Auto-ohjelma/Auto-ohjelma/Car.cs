using System;
using System.Collections.Generic;
using System.Text;

namespace Auto_ohjelma
{
    class Car
    {
        public string brand;
        public int speed;

        public Car()
        {
        }

        public void AskData()
        {
            Console.Write("Syötä merkki: ");
            brand = Console.ReadLine();
            Console.Write("Syötä huippunopeus: ");
            string speedValue = Console.ReadLine();

            int.TryParse(speedValue, out speed);
        }
        
        public void ShowInfo()
        {
            Console.WriteLine($"Auton {this.brand} huippunopeus on {this.speed}.");
        }

        public void Accelerate(string speedValue = "15")
        {
            if (!int.TryParse(speedValue, out int iSpeed))
            {
                iSpeed = 0;
            }
            
            if (iSpeed > 0)
            {
                this.speed += iSpeed;
                Console.WriteLine($"Nopeutta lisättiin {iSpeed}. Uusi nopeus on nyt {this.speed} km/h.\n");
            }

            else if (iSpeed == 0)
            {
                Console.WriteLine("Ei muutosta nopeuteen.");
            }

            else
            {
                Console.WriteLine("Negatiivista muutosta ei sallita.");
            }
                
        }

        public void Brake()
        {
            speed = 90 * speed / 100;
            Console.WriteLine($"Nopeutta hidastettiin 10%, uusi nopeus on {speed}km/h.\n");
        } 
    }
}
