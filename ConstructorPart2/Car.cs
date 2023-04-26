namespace ConstructorsPart2

{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            :base(registrationNumber)
        {
        Console.WriteLine("Car is being intialized.{0}", registrationNumber);
        }

        public Car(string registrationNumber, int serialNo)
             : base(registrationNumber,serialNo)
        {
            Console.WriteLine("Car is being intialized.{0}", registrationNumber);
            Console.WriteLine("Car is being intialized.{0}", serialNo);
        }


    }




}


