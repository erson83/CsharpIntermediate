using System;

namespace Constructors

{



    class Program

    {

        static void Main(string[] args)
        {

            // id is initialized to 1
            // the constructor will take in only the first integer
            var customer = new Customer(1);
            var order = new Order();
            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);


            // id is re-initialized to 2, and name to John.
            var customer2 = new Customer(2,"John");

            //var order2 = new Order();

            Console.WriteLine(customer2.Id);
            Console.WriteLine(customer2.Name);

            // id is re-initialized to 3, and name to Peter, and Age to 39.
            var customer3 = new Customer(3, "Peter",39);

            //var order3 = new Order();

            Console.WriteLine(customer3.Id);
            Console.WriteLine(customer3.Name);
            Console.WriteLine(customer3.Age);



        }


    }




}

