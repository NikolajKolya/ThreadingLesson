namespace ThreadingLesson;

public class NumberPrinter
{
    private int _number = 0;
    private readonly string _instanceName;
    private readonly Random _random = new Random();

    public NumberPrinter(string instanceName)
    {
        _instanceName = instanceName;
    }
    
    public void PrintNumber()
    {
        Console.WriteLine($"{ _instanceName }: { _number }");
        _number++;
        
        Thread.Sleep(_random.Next(100, 5000));
    }
}