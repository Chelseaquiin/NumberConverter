namespace NumbersInWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConvertToWords number1 = new ConvertToWords(2999999);
            
            string conversion = number1.Conversion(number1.Number);
            Console.WriteLine(conversion);

            
        }
    }
}