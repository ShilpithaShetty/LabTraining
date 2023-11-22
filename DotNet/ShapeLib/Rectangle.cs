using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
    public class Rectangle : Paint, Ishape
    {
        int Length, Breadth;
        public override void FillColor(string color)
        {
            throw new NotImplementedException();
        }
        public override void CalculateArea()
        {
            base.CalculateArea();
        }

        public void Draw()
        {
            Console.WriteLine("byee");
        }

        public void GetDetails()
        {
            throw new NotImplementedException();
        }
    }
}
