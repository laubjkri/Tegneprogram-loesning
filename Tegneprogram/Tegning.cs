using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tegneprogram
{
    class Tegning
    {
        private const string FILENAME = "ol.svg";

        public void Tegn(Firkant[] firkanter, Cirkel[] cirkler)
        {
            int antalLinjer = 3 + firkanter.Length + cirkler.Length;
            string[] lines = new string[antalLinjer];

            lines[0] = "<?xml version=\"1.0\"?>";
            lines[1] = "<svg xmlns = \"http://www.w3.org/2000/svg\" width=\"800\" height=\"800\"> ";

            int i = 2;
            foreach(Firkant firkant in firkanter)
            {
                lines[i] = firkant.GetSvg();
                i++;
            }

            foreach(Cirkel cirkel in cirkler)
            {
                lines[i] = cirkel.GetSvg();
                i++;
            }

            lines[i] = "</svg >";
            File.WriteAllLines(FILENAME, lines);
            var f = File.OpenRead(FILENAME);
            string location = f.Name;
            f.Close();
            Console.WriteLine($"Jeg har gemt dit billede i denne fil: {location}");

        }
    }
}
