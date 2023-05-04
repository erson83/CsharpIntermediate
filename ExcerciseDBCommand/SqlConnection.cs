namespace ExDBCommand



{

    public class SqlConnection : DBCommand
    {
        public SqlConnection(string connectionstring, string sqlquery)
        : base(connectionstring, sqlquery)
        {

        }


        public override void Open()
        {
            Console.WriteLine("Opening SQL connection: " + ConnectionString);

        }

        public override void Close()
        {
            Console.WriteLine("Closing SQL connection.  ");
        }

    }



}

