namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            var num1 = 1;
            var num2 = 10;

            var answer = Add(num1, num2);
            Console.WriteLine(answer);

            var num3 = 19.5;
            var num4 = 21.6;

            var decimalAnswer = Add(num3, num4);
            Console.WriteLine(decimalAnswer);


            Add(1, 0, true);
            

        }
        public static int Add(int x, int y)
        {
            return x + y;

        }

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static int Add(int c, int d, bool answer)
        {
            if(answer == true)
            {
                if (c + d == 1)
                {
                    int total = c + d;
                    Console.WriteLine($"{total} dollar");

                }
                else
                {
                    int total = c + d;
                    Console.WriteLine($"{total} dollars");

                }

            }

            return c + d;
        }
    }

}
