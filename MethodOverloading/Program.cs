namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool isTrue)
        {
            int sum = a + b;

            if (!isTrue)
            {
                return "Boolean value is false";
            }

            if(sum == 1)
            {
                return $"{sum} dollar";
            } else
            {
                return $"{sum} dollars";
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine(Add(5,2));
            Console.WriteLine(Add(5.3M, 2.8M));
            Console.WriteLine(Add(1, 0, true));
            Console.WriteLine(Add(1, 6, true));
            Console.WriteLine(Add(1, 7, false));
        }
    }
}
