namespace MathProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            var sum = (a + b) / 4;


            if (sum <= 0)
            {
                Console.WriteLine(0);
            }

            else if (a < sum || b < sum)
            {
                Console.WriteLine(Math.Min(a, b));
            }

            else
            {
                bool rule = true;

                while (rule)
                {
                    var tempSum = (a / sum) + (b / sum);

                    if (sum == 0)
                    {
                        Console.WriteLine(sum);
                        rule = false;
                    }
                    else if (tempSum == 4)
                    {
                        Console.WriteLine(sum);
                        rule = false;
                    }

                    else
                    {
                        sum--;
                    }
                }
            }
        }
    }
}
