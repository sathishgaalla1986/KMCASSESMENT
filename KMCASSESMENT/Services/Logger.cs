using KMCASSESMENT.Infrastruture;

namespace KMCASSESMENT.Services
{
    public class Logger: ILoggerService
    {
        public void LogInfo(string message)
        {
            Console.WriteLine($"[INFO] {DateTime.Now}: {message}");
        }

        public void LogError(string errorMessage)
        {
            Console.WriteLine($"[ERROR] {DateTime.Now}: {errorMessage}");
        }
    }
}
