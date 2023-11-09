namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICreditManager needCreditManager = new NeedCreditManager();
            ICreditManager vechileCreditManager = new VechileCreditManager();
            ICreditManager mortageCreditManager = new MortageCreditManager();

            ILoggerService databaseLoggerService= new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>
            {new SmsLoggerService(), new FileLoggerService()};

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.GetApplication(new EsnafCreditManageer(), loggers);

            List<ICreditManager> credits = new List<ICreditManager>() {needCreditManager, vechileCreditManager };

            //applicationManager.CreditPreInfo(credits);
        }
    }
}