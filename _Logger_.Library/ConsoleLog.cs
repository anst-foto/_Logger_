namespace _Logger_.Library;

public class ConsoleLog : ILogger
{
    private static void Log(string type, string message, ConsoleColor colorText, ConsoleColor colorBackground)
    {
        Console.ForegroundColor = colorText;
        Console.BackgroundColor = colorBackground;
        Console.WriteLine($"{DateTime.Now:g} [{type}] {message}");
        Console.ResetColor();
    }
    
    
    public void LogInfo(string message)
    {
        Log("INFO", message, ConsoleColor.White, ConsoleColor.DarkBlue);
    }

    public void LogError(string message)
    {
        Log("ERROR", message, ConsoleColor.White, ConsoleColor.DarkRed);
    }

    public void LogSuccess(string message)
    {
        Log("SUCCESS", message, ConsoleColor.White, ConsoleColor.DarkGreen);
    }

    public void LogCustom(string typeOfLog, string message)
    {
        Log(typeOfLog, message, ConsoleColor.White, ConsoleColor.DarkGray);
    }
}