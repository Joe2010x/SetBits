namespace TotalBits;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input [N]: ");
        var N = Console.ReadLine();
        var nInt = int.Parse(N!);
        var total = 0;
        for (int i = 1; i < nInt + 1; i++)
        {
            var str = Convert.ToString(i,2);
            total += str.Count(c => c == '1');
        }
        Console.WriteLine($"Total bits between 1 to {N} is {total}");
    }
}