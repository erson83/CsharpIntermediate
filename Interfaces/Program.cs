using System;

namespace Testability

{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DatePlaced { get; set; }
        public Shipment Shipment { get; set; }
        public float TotalPrice { get; set; }

        public bool IsShipped
        {
            get { return Shipment != null; }
        }


    }

    public class Shipment
    {
        public float Cost { get; set; }
        public DateTime ShippingDate { get; set; }
    }


    public class ShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
            {
                return order.TotalPrice * 0.1f;
            }
            else
            {
                return 0;
            }
        }

    }


    public class OrderProcessor
    {
        // declare variables

        private readonly ShippingCalculator _shippingCalculator;

        // intialize variables

        public OrderProcessor()
        {
            this._shippingCalculator = new ShippingCalculator();
        }

        // call method

        public void Process(Order order)
        {
            if (order.IsShipped)
            {
                throw new InvalidOperationException("this order is already processed");
            }

            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };

        }

    }



    class Program

    {
        static void Main(string[] args)
        {

            var orderProcessor = new OrderProcessor();
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process(order);

        }
    }


}


