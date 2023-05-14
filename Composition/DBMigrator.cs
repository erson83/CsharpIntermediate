﻿namespace Composition

{
    public class DbMigrator
    {



        //the readonly keyword is used to mark a field or variable as
        //read-only, meaning that it can only be set once, typically at
        //initialization time or in the constructor. Once it has been set,
        //it cannot be modified.


        private readonly Logger _logger;     // passing in Logger variable class here

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