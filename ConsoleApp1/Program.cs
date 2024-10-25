using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        MyList<int> list= new MyList<int>(7);
        list.Add(14);
        list.Add(18);
        list.Add(0);
        list.Add(-123);
        Console.WriteLine(list.ToString());

        MyList<char> list2= new MyList<char>(['b','a','b', 'c', 'd', 'b', 'b', 'e', 'f', 'b']);
        Console.WriteLine(list2.ToString());
        list2.DeleteAll('b');
        Console.WriteLine(list2.ToString());
    }
}