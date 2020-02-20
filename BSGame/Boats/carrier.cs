using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSGame
{
    class Carrier: Ship
    {
        public Carrier()
        {
            Name = "Carrier";

            Width = 5;
            CurrentStatus = CurrentStatus.Carrier;
            string[] strcover = new string[5];
            Console.WriteLine("Enter Air-Carrier occupied coordinates (ex. A1,A2,A3,A4,A5): ");
            string c = Console.ReadLine();
            strcover = c.Split(",", 5, StringSplitOptions.RemoveEmptyEntries);
            Cover = strcover.OfType<string>().ToList(); 
        }
    }
}