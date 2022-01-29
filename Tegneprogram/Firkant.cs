using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tegneprogram
{
    class Firkant
    {
        public int Hojde { get; set; }
        public int Bredde { get; set; }

        public int X { get; set; }

        public int Y { get; set; }
        public string Farve { get; set; }

        public Firkant(string farve) 
        {
            Farve = farve;
        }
            
        public string GetSvg()
        {
            return $"<rect x=\"{X}\" y=\"{Y}\" width=\"{Bredde}\" height=\"{Hojde}\" style=\"fill: none; stroke-width:3; stroke: {Farve}\" />";
        }
    }
}
