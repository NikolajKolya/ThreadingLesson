// See https://aka.ms/new-console-template for more information

using ThreadingLesson;

public class Program
{
    private static ResultClass _resultClass = new ResultClass();
    
    public static void Main(string[] args)
    {
        for (var i = 0; i < 4; i++)
        {
            var trheadedPrinter = new NumberPrinter(_resultClass, $"{i}");
            var thread = new Thread(trheadedPrinter.StartPrinting);
            thread.Start();
        }

        var resultThread = new Thread(PrintResult);
        resultThread.Start();

        Console.ReadKey();
    }

    public static void PrintResult()
    {
        while (true)
        {
            Console.WriteLine($"{ _resultClass.Message }");
            Thread.Sleep(500);
        }
    }
}



