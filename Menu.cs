using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2D261
{
    internal class Menu
    {
        public void Execute()
        {
            float b;
            float h;

            Console.WriteLine("Introduce la base");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la altura");
            h = float.Parse(Console.ReadLine());

            Triangle t = new Triangle(b, h);
            Console.WriteLine($"El área es {t.CalculateArea()}");
        }
    }
}
