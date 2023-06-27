public class Program
{
    static void Main(string[] args)
    {

        int[] numbers = new int[10] { 78, 45, 12, 89, 23, 90, 11, 4, 8, 9 };
        int[] nos = new int[10] { 1, 2, 3, 4, 5, 0, 0, 0, 0, 0 };

        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }


        Array.Sort(numbers);
        Console.WriteLine("------after sort------");
        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }
        Array.Reverse(numbers);
        Console.WriteLine("------after reverse------");
        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }

        Array.Copy(numbers, 3, nos, 5, 3);
        Console.WriteLine("------------------");
        foreach (var item in nos)
        {
            Console.WriteLine(item);
        }


    }
}
