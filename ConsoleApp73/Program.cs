namespace ConsoleApp73
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Say your number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = number1;
            int count = 0;
            while (number2 != 0)
            {
                number2 = (number2 - (number2 % 10)) / 10;
                count++;
            }
            number2 = number1;
            // Console.WriteLine(count);
            int sum = 0;
            while (number2 != 0)
            {
                int power = 1;
                int digit = number2 % 10;
                for (int i = 0; i < count; i++)
                {
                    power = power * digit;
                }
                sum = sum + power;
                number2 = (number2 - digit) / 10;
            }
            if (number1 == sum)
            {
                Console.WriteLine(number1 + " is an narciss number");
            }
            else 
            {
                Console.WriteLine(number1 + " is not an narciss number");
            }
        }
    }
}