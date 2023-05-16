namespace Properties2

{
    // becareful of the camel and pascal conventions for standard and getset methods

    public class Car
    {
        // declare variables Pascal
        public int Speed;

        // intialize
        public Car(int aspeed)
        {
            this.Speed = aspeed;
        }

    }

    class Truck
    {
        // using getset method
        // we can set variable to private
        // in Main program, we are accessing it using the GET Method.

        // declare variable camel case
        // private must use _
        private int _weight;


        // intialize weight
        public Truck(int aweight)
        {
            _weight = aweight;
        }

        // delcare getset Pascal Case
        public int Weight
        {

            get { return _weight; } //read values

            set // write values
            {
                // can set rule here, control the weight variable here

                if (value > 500)
                    _weight = 500;
                else
                    _weight = value;  // this value is gotten from Main Program

            }

        }


    }


    class Program

    {

        static void Main(string[] args)
        {

            var car = new Car(400);

            // i can easily change the car speed here without any restriction
            
            car.Speed = 100000;

            //because i want to be able to pull the speed variable, i cannot set speed as private.
            Console.WriteLine(car.Speed);


            // using getters and setters add seucirty to fields by encapsulation
            // the combine both fields and methods
            // share name with a field
            // get == used to return property value
            // set == used to assign new value


            var truck = new Truck(2000000);

            // over here, we cannot change the weight of the Truck.
            // only inside setter, than we can change the weight

            Console.WriteLine(truck.Weight);



        }


    }





}