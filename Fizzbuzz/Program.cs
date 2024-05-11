class Program
{

    public static void Main(String[] args)
    {

        FizzBuzz();

    }

    static void FizzBuzz()
    {
        for (int i = 1; i <= 100; i++)
        {
            bool fizz = i % 3 == 0;
            bool buzz = i % 5 == 0;
            if (fizz && buzz)
            {
                Console.Write("FizzBuzz ");
            }
            else if (fizz)
            {
                Console.Write("Fizz ");
            }
            else if (buzz)
            {
                Console.Write("Buzz ");
            }
            else
            {
                Console.Write(i + " ");
            }
        }
    }
}