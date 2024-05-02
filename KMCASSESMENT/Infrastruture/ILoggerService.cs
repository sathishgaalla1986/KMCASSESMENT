namespace KMCASSESMENT.Infrastruture
{
    public interface ILoggerService
    {
        void LogInfo(string message);
        void LogError(string errorMessage);
    }
}
