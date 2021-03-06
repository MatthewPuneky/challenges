namespace challenges;

public static class Printer
{
    public static void PrintLine(string line)
    {
        foreach(var @char in line)
        {
            if(@char != ' ')
            {
                Wait();
            }
            Console.Write(@char);
        }
        Wait();
        Console.WriteLine();
    }

    public static void PrintLine()
    {
        Console.WriteLine();
    }

    public static void Print(string partialLine)
    {
        foreach (var @char in partialLine)
        {
            Wait();
            Console.Write(@char);
        }
    }

    public static char ReadKeyChar()
    {
        return Console.ReadKey().KeyChar;
    }

    public static string ReadLine()
    {
        return Console.ReadLine();
    }

    public static void ClearPreviousLine()
    {
        Console.SetCursorPosition(0, Console.CursorTop - 1);
        ClearCurrentConsoleLine();
    }

    public static void ClearCurrentConsoleLine()
    {
        int currentLineCursor = Console.CursorTop;
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, currentLineCursor);
    }

    private static void Wait()
    {
        Thread.Sleep(2);
    }

    public static void Clear()
    {
        Console.Clear();
    }
}