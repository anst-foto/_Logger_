namespace _Logger_.Library;

public class FileLog : ILogger
{
    private string _pathSuccess;
    private string _pathError;
    private string _pathCustom;
    private string _pathInfo;

    public FileLog(string pathSuccess, string pathError, string pathCustom, string pathInfo)
    {
        _pathSuccess = pathSuccess;
        _pathError = pathError;
        _pathCustom = pathCustom;
        _pathInfo = pathInfo;
    }

    private void Log(string type, string message, string path)
    {
        using var file = new StreamWriter(path, false);
        file.WriteLine($"{DateTime.Now:g} [{type}] {message}");
        /*try
        {
            file = new StreamWriter(path, append: true);
            file.WriteLine($"{DateTime.Now:g} [{type}] {message}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        finally
        {
            file.Close();
        }*/
    }

    public void LogInfo(string message)
    {
        Log("INFO", message, _pathInfo);
    }

    public void LogError(string message)
    {
        Log("ERORR", message, _pathError);
    }

    public void LogSuccess(string message)
    {
        Log("SUCCESS", message, _pathSuccess);
    }

    public void LogCustom(string typeOfLog, string message)
    {
        Log(typeOfLog, message, _pathCustom);
    }
}