using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 namespace BSGame
 {
     public class ShipsLocation
     {
        public List<Ship> Ships { get; set; }

        public ShipsLocation()
        {
            Ships = new List<Ship>();
            
            Ship aircar = new Carrier();
            Ships.Add(aircar);
            Ship batship = new Battleship();
            Ships.Add(batship);
            Ship cruis = new Cruiser();
            Ships.Add(cruis);
            Ship submar = new Submarine();
            Ships.Add(submar);
            Ship destr = new Destroyer();
            Ships.Add(destr);
        }
     }
 }