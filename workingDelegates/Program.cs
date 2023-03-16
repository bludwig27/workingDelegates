namespace Assignment8ex2
{
    // declaring custom delegate

    public delegate double mult(double x,double y);
    public class MathSolutions
    {
        public double GetSum(double x, double y)
        {
            return x + y;
        }
        public double GetProduct(double a, double b)
        {
            return a * b;
        }
        public void GetSmaller(double a, double b)
        {
            if (a < b)
                Console.WriteLine($" {a} is smaller than {b}");
            else if (b < a)
                Console.WriteLine($" {b} is smaller than {a}");
            else
                Console.WriteLine($" {b} is equal to {a}");
        }
        static void Main(string[] args)
        {

            // create a class object
            MathSolutions answer = new MathSolutions();
            Random r = new Random();
            double num1 = Math.Round(r.NextDouble() * 100);
            double num2 = Math.Round(r.NextDouble() * 100);


            //Func delegate
            Func<double, double, double> add = answer.GetSum;
            Console.WriteLine($" {num1} + {num2} = {add(num1, num2)}");

            //custom delegate
            mult myMult = new mult(answer.GetProduct);
            Console.WriteLine($" {num1} * {num2} = {myMult(num1, num2)}");

            //Action delegate
            Action<double,double> least = answer.GetSmaller;
            least(num1,num2);
        }
    }
}