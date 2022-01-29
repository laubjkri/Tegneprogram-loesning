using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tegneprogram
{
    class Cirkel
    {
        public int Diameter { get; set; }

        public int X { get; set; }

        public int Y { get; set; }
        public string Farve { get; set; }

        public Cirkel(string farve)
        {
            Farve = farve;
        }

        public string GetSvg()
        {
            int Radius = Diameter / 2;
            return $"<circle cx=\"{X}\" cy=\"{Y}\" r=\"{Radius}\" style=\"fill: none; stroke-width:3; stroke: {Farve}\" />";
        }


    }
}
