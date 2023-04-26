namespace AccessModifiers

{
    public class GoldCustomer : Customer
    {
        public void OfferVoucher()
        {
            this.CalculateRating(excludeOrders: true);
        }
    }


    class Program

    {

        static void Main(string[] args)
        {

            var customer = new Customer();
            customer.Promote();
            // var rating = customer.CalculateRating();
           // Console.WriteLine("Returned CalculateRating: "+ rating);

        }


    }




}

