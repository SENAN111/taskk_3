using ConsoleApp16;

namespace Extension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            string text= Console.ReadLine();
            string text_2= Console.ReadLine();
            Console.WriteLine(Extention.IsOdd(number));
            Console.WriteLine(Extention.IsOdd(number));
            Console.WriteLine(Extention.HasDigit(text));
            Console.WriteLine(Extention.Capitalize(text_2));
        }
    }
}