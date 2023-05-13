namespace ThreadingLesson;

public class ResultClass
{
    private Mutex _lock = new Mutex();
    
    public string Message { get; private set; }

    public void SetMessage(string message)
    {
        _lock.WaitOne();

        try
        {
            Message = message;
        }
        finally
        {
            _lock.ReleaseMutex();
        }
    }
}