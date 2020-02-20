using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSGame
{
    class Destroyer: Ship
    {
        public Destroyer()
        {
            Name = "Destroyer";
            Width = 1;
            CurrentStatus = CurrentStatus.Destroyer;
            string[] strcover = new string[5];
            Console.WriteLine("Enter Destroyer occupied coordinates (ex. A1): ");
            string c = Console.ReadLine();
            strcover = c.Split(",", 1, StringSplitOptions.RemoveEmptyEntries);
            Cover = strcover.OfType<string>().ToList(); 
        }
    }
}