using System.Collections.Generic;

namespace MethodOveride3

{



    class Program

    {

        static void Main(string[] args)
        {
            var dog = new Dog();
            var cat = new Cat();
            var parrot = new Parrot();

            dog.Speak();

            cat.Speak();

            parrot.Speak();


        }


    }




}
