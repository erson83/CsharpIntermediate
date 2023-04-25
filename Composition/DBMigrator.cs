namespace Composition

{
    public class DbMigrator
    {

        // passing in Logger variable class here
        private readonly Logger _logger;

        public DbMigrator(Logger logger)
        {
            this._logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("We are migrating.");

        }

        public void MigratePartial()
        {
            _logger.Log("We are migrating partial only.");

        }

    }




}