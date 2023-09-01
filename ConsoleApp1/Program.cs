internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Input a");
        int c = 0;
        int a = Convert.ToInt16 (Console.ReadLine());
        Console.WriteLine("Input b");
        int b = Convert.ToInt16(Console.ReadLine());
        c= a+b; 
        Console.WriteLine("a+b={0}", c);
    }
}