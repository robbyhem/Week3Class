using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lister lister196 = new Lister();
            lister196.Name = "Lister 196";
            lister196.HasPowerSource = true;
            lister196.Rating = 12;
            lister196.HasStarterEaten = true;
            bool hasStarted = lister196.Start();
            //lister196.Stop();
            bool hasStopped = lister196.Stop();
            
           int OilLevel = 45;

            Mikano mikano = new Mikano();
            mikano.Name = "Mikano 1040";
            mikano.OilQuantity = 0;
            
            if (hasStarted)
            {
                Console.WriteLine($"{lister196.Name} is running...");
            }
            else
            {
                Console.WriteLine($"{lister196.Name} failed to start.");
            }
            if (hasStopped)
            {
                Console.WriteLine($"{lister196.Name} has stopped");
            }
            else
            {
                Console.WriteLine($"{lister196.Name} Failed to stop");
            }

            if (mikano.OilLevel < 50)
            {
                Console.WriteLine();
            }
            
            if (OilLevel < 50)
            {
                Console.WriteLine("{0} has low oil, can't start without refill", mikano.Name);
            } else
            {
                Console.WriteLine("{0} is ZOOM ZOOM!!!", mikano.Name);
            }

            Console.WriteLine(mikano.OilQuantity);
            Console.WriteLine(mikano.RefillOil());

            Console.ReadLine();
        }
    }
}
