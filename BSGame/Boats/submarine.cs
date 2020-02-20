using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BSGame
{
    class Submarine: Ship
    {
        public Submarine()
        {
            Name = "Submarine";
            Width = 2;
            CurrentStatus = CurrentStatus.Submarine;
            string[] strcover = new string[5];
            Console.WriteLine("Enter Submarine occupied coordinates (ex. A1,A2): ");
            string c = Console.ReadLine();
            strcover = c.Split(",", 2, StringSplitOptions.RemoveEmptyEntries);
            Cover = strcover.OfType<string>().ToList(); 
        }
    }
}