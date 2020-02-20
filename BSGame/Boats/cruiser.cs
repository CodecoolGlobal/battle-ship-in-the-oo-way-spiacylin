using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSGame
{
    class Cruiser: Ship
    {
        public Cruiser()
        {
            Name = "Cruiser";
            Width = 3;
            CurrentStatus = CurrentStatus.Cruiser;
            string[] strcover = new string[3];
            Console.WriteLine("Enter Cruiser occupied coordinates (ex. A1,A2,A3): ");
            string c = Console.ReadLine();
            strcover = c.Split(",", 3, StringSplitOptions.RemoveEmptyEntries);
            Cover = strcover.OfType<string>().ToList(); 
        }
    }
}