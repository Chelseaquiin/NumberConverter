namespace NumbersInWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConvertToWords number1 = new ConvertToWords(299999);
            
            string conversion = number1.Conversion(number1.Number);
            Console.WriteLine(conversion);

            ConvertToNumbers word = new ConvertToNumbers("Two thousand and eight");
            Console.WriteLine(word.Words);
        }
    }
}