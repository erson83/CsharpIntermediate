namespace Composition

{
    public class Installer
    {

        // passing in Logger variable class here
        private readonly Logger _logger;

        public Installer(Logger logger)
        {
            this._logger = logger;
        }

        public void Install()
        {

            _logger.Log("We are installing.");
        }

    }




}