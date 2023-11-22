using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
    public abstract class Paint
    {
        public  virtual void CalculateArea() { }
        public abstract  void FillColor(string color) ;

        
    }
}
