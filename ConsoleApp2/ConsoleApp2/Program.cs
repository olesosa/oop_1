public class Counter
{
    private int number;
    private int min;
    private int max;

    public Counter(int min = 1, int max = 10, int number = 5)
    {
        min = min;
        max = max;
        number = number;
    }

    public int CurrentNumber
    {
        get { return number; }
    }

    public void Print(int number)
    {
        Console.WriteLine(number);
    }

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
