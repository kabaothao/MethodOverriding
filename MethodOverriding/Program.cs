// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());


            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }






/*
 Overloading is having a method with the same name but different signatures overwriting on the other

side is about changing the implementation of an inherited method.

 */