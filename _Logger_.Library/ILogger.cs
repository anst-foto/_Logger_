namespace _Logger_.Library;

public interface ILogger
{
    public void LogInfo(string message);
    public void LogError(string message);
    public void LogSuccess(string message);
    public void LogCustom(string typeOfLog, string message);
}