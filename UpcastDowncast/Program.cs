using System;
using System.IO;
using System.Collections;
namespace UpcastDowncast

{
    //

    class Program

    {

        static void Main(string[] args)
        {
            Text text = new Text();
                // converting object reference to base class reference
            Shape shape = text;

            text.Width = 200;
            shape.Width = 100;


            // parent takes control! shape > text
            Console.WriteLine(text.Width);


            // upcasting
            // MomeoryStream will take streamreader class
            StreamReader reader = new StreamReader(new MemoryStream());

            // array can contain any datatype
            var list = new ArrayList();
            list.Add(1);
            list.Add("Most");
            list.Add(new Text());

            // list is enforced. Upcast so that any new list added, must be of same type
            var anotherlist = new List<int>();
            anotherlist.Add(1);
            anotherlist.Add(2);


            //
            Shape2 shape2 = new Text2();
            // not able to get Fontsize and FontType from Text2 child class
            // only able to get from Shape2 parent class
            shape2.Width = 100;
            // in order to access the Text class, we need to downcast from parent to child class
            Text2 text2 = (Text2)shape2;
            text2.FontName = "Arial";


        }


    }




}

