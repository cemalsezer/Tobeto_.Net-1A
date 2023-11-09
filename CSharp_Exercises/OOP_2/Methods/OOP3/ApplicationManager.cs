using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplicationManager
    {
        //Method injection
        public void GetApplication(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            creditManager.Calculate();
            foreach(var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
        public void CreditPreInfo(List<ICreditManager> credits)
        {
            foreach(var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
