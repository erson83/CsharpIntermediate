using System;

namespace AbstractClasses

{

    class Program

    {

        static void Main(string[] args)
        {
            // remember this is different if we use abstract
            // we cannot instatiate Shape
            // we cannot - var shape = new Shape();


            var circle = new Circle();
            circle.Draw();


            var rectangle = new Rectangle();
            rectangle.Draw();

            rectangle.Copy();


        }

    }


}