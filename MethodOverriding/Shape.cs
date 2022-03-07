using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            //base.Draw(); //Base is a reference to the parent class. Any code specific to the circle itself

            Console.WriteLine("Draw a circle");
        }

    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }


    public class Triangle : Shape
    {
        public override void Draw()
        {
            //base.Draw(); //Base is a reference to the parent class. Any code specific to the circle itself

            Console.WriteLine("Draw a triangle");
        }
    }


    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }




        public virtual void Draw()
        {

        }


    }
}
