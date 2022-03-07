using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes) //So the parameter or this method is of type list of shapes so every element of this list is going to be a shape object or an object whose type derives from the shape class.
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
                
            }

        }
    }
}
