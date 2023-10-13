using counts;


internal class Program
{
    private static void Main(string[] args)
    {

        Count cnt = new Count(1, 1, 1, 1, 1, "Note");
        cnt.print();
        Console.WriteLine("\n");
        cnt.balance += 1000;
        cnt.print();
        Console.WriteLine("\n");
        Count cnt2 = new Count(25, 21, 23, 12, 1442, "Note2");
        cnt2.print();
    }
}