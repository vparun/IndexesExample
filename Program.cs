public class Program
{
    static void Main(string[] args)
    {
        // Get the value using different kind indexing
        var text = "0123456789";
        var numbers = new[] { 10, 20, 30, 40, 50, 60, 70, 80, 90 };

        // Example 1
        Console.WriteLine("Example 1");
        Console.WriteLine(text[text.Length - 1]);
        Console.WriteLine(numbers[numbers.Length - 2]);

        // Example 2
        Console.WriteLine("Example 2");
        Console.WriteLine(text[^1]);
        Console.WriteLine(numbers[^2]);
        int n = 1;
        Console.WriteLine(text[^n]);
        Console.WriteLine(numbers[^(n + 1)]);

        // Example 3
        Console.WriteLine("Example 3");
        Console.WriteLine(text[new Index(1, true)]);
        Console.WriteLine(numbers[new Index(2, true)]);

        // Example 4

    }
}