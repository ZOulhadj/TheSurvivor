using System;

namespace TheSurvivor.Source.Utilities
{
    enum LogType
    {
        LOG,
        WARNING,
        ERROR
    }

    class Logging
    {
        public static void Log(LogType logType, string logMessage)
        {
            switch (logType)
            {
            case LogType.LOG:
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(logMessage);
                break;
            case LogType.WARNING:
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(logMessage);
                break;
            case LogType.ERROR:
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(logMessage);
                break;
            }

        }
    }
}
