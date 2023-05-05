namespace ExDBCommand

{
    public class DBCommand

    {
        public string ConnectionString;
        public string SqlQuery;


        public DBCommand(string connectionstring)
        {
            if (string.IsNullOrWhiteSpace(connectionstring))
                throw new ArgumentException("Connection string cannot be null or empty");
            this.ConnectionString = connectionstring;

        }

        public DBCommand(string connectionstring, string sqlquery)
            : this(connectionstring)
        {
            if (string.IsNullOrWhiteSpace(sqlquery))
                throw new ArgumentException("sqlquery string cannot be null or empty");
            this.SqlQuery = sqlquery;

        }


        public virtual void  Open()
        {
        }

        public virtual void Close()
        {
        }

        public virtual void Execute()
        {
            Console.WriteLine("Connecting using query: " + SqlQuery);
        }

    }


}


