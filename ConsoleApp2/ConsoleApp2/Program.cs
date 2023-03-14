public class Counter
{
    public int number;
    public int min;
    public int max;

    public Counter(int min = 1, int max = 10, int number = 5)
    {
        this.min = min;
        this.max = max;
        this.number = number;
    }

    public int CurrentNumber => number;

    public void Increment()
    {
        if (number < max)
        {
            number++;
        }
    }

    public void Decrement()
    {
        if (number > min)
        {
            number--;
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

        try
        {
            b.Decrement();
            Console.WriteLine(b.CurrentNumber);

            if (b.number <= b.min)
            {
                throw new Exception("Minimum value");
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}
