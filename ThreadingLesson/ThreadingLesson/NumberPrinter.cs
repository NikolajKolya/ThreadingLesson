namespace ThreadingLesson;

public class NumberPrinter
{
    private readonly Random _random = new Random();
    
    private readonly ResultClass _resultClass;
    private readonly string _printerName;
    

    public NumberPrinter(ResultClass resultClass, string printerName)
    {
        _resultClass = resultClass;
        _printerName = printerName;
    }

    public void StartPrinting()
    {
        while (true)
        {
            PrintNumber();
        }
    }
    
    public void PrintNumber()
    {
        var result = _random.Next(10);
        _resultClass.SetMessage($"Result from printer { _printerName }: { result }");
        
        Thread.Sleep(_random.Next(0, 1000));
    }
}