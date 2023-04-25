namespace Composition

{
    // creating a common class to be used in Installer and DBMigrator
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }

    }


}