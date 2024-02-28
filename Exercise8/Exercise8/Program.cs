namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int number = 30;

            for (int i = 0; i <= 30; i++)
            {
                Console.WriteLine(i + " x " + number + " = " + i * number);
            }

            Console.WriteLine("******");
        }
    }
}