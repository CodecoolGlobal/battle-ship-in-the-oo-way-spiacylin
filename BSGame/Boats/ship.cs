using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSGame
{
    public abstract class Ship
    {
        public string Name { get; set; }
        public int Width { get; set; }
        public int Hits { get; set; }
        public CurrentStatus CurrentStatus { get; set; }
        public List<string> Cover {get; set;}
    }
}