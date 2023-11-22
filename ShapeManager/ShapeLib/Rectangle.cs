using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
    public class Rectangle :Paint, IShape
    {
        public int Length;
        public int Breadth;
     
        public string Draw()
        {
            return $"A rectangle of length {this.Length} and breadth {this.Breadth} has been drawn.\n";
        }

        public string GetDetails()
        {
            return $"Rectangle's Length: {this.Length}\nRectangle's Breadth: {this.Breadth}\n";
        }

        public override string CalculateArea()
        {
            return $"Area of Rectangle is: {Length * Breadth} \n\n";
        }
    }
}
