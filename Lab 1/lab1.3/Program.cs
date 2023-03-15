using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1324, 214123, -228, 1488, 1, 128, -1921, -202020 };

        var digits = numbers.Where(n => n > 0).Select(n => n % 10).SelectMany(n => n.ToString()).Distinct().ToList();

        Console.WriteLine(string.Join("",digits));


    }
}