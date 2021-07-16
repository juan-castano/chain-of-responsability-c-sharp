using System;

namespace chain_of_responsability.Services.Implementation
{
    public class LoggerService
    {
        public void LogInfo(string message)
        {
            Console.WriteLine(message);
        }
    }
}
