public class Counter
{
    private int number;
    private int min;
    private int max;

    public Counter(int min = 1, int max = 10, int number = 5)
    {
        this.min = min;
        this.max = max;
        this.number = number;
    }

    public int CurrentNumber => number;

    public void Increment()
    {
        try
        {
            if (number < max)
            {
                number++;
            }
            else
            {
                throw new Exception();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("error");
        }
    }

    public void Decrement()
    {
        try
        {
            if (number > min)
            {
                number--;
            }
            else
            {
                throw new Exception();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("error");
        }
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\tIнкремент");
        Counter a = new Counter();
        Console.WriteLine(a.CurrentNumber);

        a.Increment();
        Console.WriteLine(a.CurrentNumber);

        Console.WriteLine("\tДекремент");
        Counter b = new Counter(10, 20, 10);
        Console.WriteLine(b.CurrentNumber);

        b.Decrement();
        Console.WriteLine(b.CurrentNumber);

    }
}
