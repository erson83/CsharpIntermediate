using System;

namespace ConstructorsPart2

{
    // inheritance 

    class Program

    {

        static void Main(string[] args)
        {
            string licenseNoCar = "SG1234E";
            var car = new Car(licenseNoCar, 123);

            string licenseNoTruck = "TRU1234";
            var truck = new Truck(licenseNoTruck);

        }


    }




}


