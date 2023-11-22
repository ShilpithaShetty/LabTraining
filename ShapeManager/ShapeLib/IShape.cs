using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
    internal interface IShape
    {
        string Draw();

        string GetDetails();

    }

    public abstract class Paint
        {
         public virtual string CalculateArea()
        {
            return "Area";
        }
        
        //abstract void FillColor(string color) { }
       
    }
}
