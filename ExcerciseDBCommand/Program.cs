namespace ExDBCommand

{


    public class Program


    {

        static void Main(string[] args)
        {

           var connectionstring = "120.11.11.11";
            var sqlquery = "Select * from XXXX";

            var sqlconnection = new SqlConnection(connectionstring,sqlquery);
            sqlconnection.Execute();


            var oracleconnection = new OracleConnection(connectionstring);
            oracleconnection.Open();
            oracleconnection.Execute();
            oracleconnection.Close();


        }


    }




}


