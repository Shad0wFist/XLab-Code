internal class Program
{
    private static void Main(string[] args)
    {
        int i = 0;
        long l = (long)int.MaxValue + 3;

        Console.WriteLine($"l = {l}");

        i = (int)l;

        Console.WriteLine($"i = {i}");
        var result = Console.ReadLine();
        Console.WriteLine(result);
    }
}