using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSGame
{
    class Battleship: Ship
    {
        public Battleship()
        {
            Name = "Battleship";
            Width = 4;
            CurrentStatus = CurrentStatus.Battleship;
            string[] strcover = new string[4];
            Console.WriteLine("Enter Battleship occupied coordinates (ex. A1,A2,A3,A4): ");
            string c = Console.ReadLine();
            strcover = c.Split(",", 4, StringSplitOptions.RemoveEmptyEntries);
            Cover = strcover.OfType<string>().ToList(); 
        }
    }
}