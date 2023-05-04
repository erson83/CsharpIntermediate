namespace ExDBCommand

{
    public class OracleConnection : DBCommand
    {

        public OracleConnection(string connectionstring)
            :base(connectionstring)
        {

         }


        public override void Open()
        {
            Console.WriteLine("Opening Oracle connection: " + ConnectionString);

        }

        public override void Close()
        {
            Console.WriteLine("Closing Oracle connection: ");

        }


    }




}


