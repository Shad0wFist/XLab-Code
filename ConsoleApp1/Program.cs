using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        MyList list= new MyList(7);
        list.Add(14);
        list.Add(18);
        list.Add(0);
        list.Add(-123);
        Console.WriteLine(list.ToString());

        MyList list2= new MyList([1,2,3,2,4,5,2,6,2,2,2]);
        Console.WriteLine(list2.ToString());
        list2.DeleteAll(2);
        Console.WriteLine(list2.ToString());
    }
}