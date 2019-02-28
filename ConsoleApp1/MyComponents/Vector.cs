using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundacion.Jala.Dev27.OscarCortez
{
    public class Vector
    {

        public int PointLength { get; set; }
        public int x { get; set; }
        public int y { get; set; }

        public Vector(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector(List<int> point)
        {
            x = point.ElementAt(0);
            y = point.ElementAt(1);
        }

        public Vector Sum(Vector vector)
        {
            var result = new Vector(x + vector.x, y + vector.y);
            return result;
        }

        public int DotProduct(Vector vector)
        {
            int result = (x * vector.x) + (y * vector.y);
            return result;
        }

        public double Length()
        {            
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }

        public string Show()
        {
            return $"[{x},{y}]";
        }
    }
}
