public class SimpleList1
{
    static void Main(string[] args)
    {
        List<double> numbers = new List<double>();
        do
        {
            Console.Write("Enter the number: ");
            string? numberString = Console.ReadLine();
            if (numberString == null)
            {
                return;
            }
            bool res = double.TryParse(numberString, out double result);
            if (!res)
            {
                Console.WriteLine($"Could not convert {numberString} to double");
                break;
            }
            numbers.Add(result);
            Console.WriteLine($"Average: {numbers.Average()}");
        }
        while (true);
    }
}
