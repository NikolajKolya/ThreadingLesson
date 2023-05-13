// See https://aka.ms/new-console-template for more information

using ThreadingLesson;

public class Program
{
    public static void Main(string[] args)
    {
        var thread1 = new Thread(StartPrinter1);
        var thread2 = new Thread(StartPrinter2);
        
        thread1.Start();
        thread2.Start();

        Console.ReadLine();
    }

    public static void StartPrinter1()
    {
        var printer1 = new NumberPrinter("Printer 1");
        
        while (true)
        {
            printer1.PrintNumber();
        }
    }
    
    public static void StartPrinter2()
    {
        var printer2 = new NumberPrinter("Printer 2");
        
        while (true)
        {
            printer2.PrintNumber();
        }
    }
}



