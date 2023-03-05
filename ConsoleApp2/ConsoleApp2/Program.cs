public class Counter
{
    private int _number;
    private int _min;
    private int _max;

    public Counter(int min = 1, int max = 10, int number = 5)
    {
        _min = min;
        _max = max;
        _number = number;
    }

    public int CurrentNumber
    {
        get { return _number; }
    }

    public void Print(int _number)
    {
        Console.WriteLine(_number);
    }

    public void Increment()
    {
        if (_number < _max)
        {
            _number++;
        }
    }

    public void Decrement()
    {
        if (_number > _min)
        {
            _number--;
        }
    }

}
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\tІнкремента");
        Counter a = new Counter();
        a.Print(a.CurrentNumber);

        a.Increment();
        a.Print(a.CurrentNumber);

        Console.WriteLine("\tДекремента");
        Counter b = new Counter(10, 20, 15);
        b.Print(b.CurrentNumber);

        b.Decrement();
        b.Print(b.CurrentNumber);
    }
}