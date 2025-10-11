namespace BlazorStart.Components.Introduction
{
    public partial class Fibonacci
    {
        public int num { get; set; }
        // int fibonacci(int num)
        // {
        // 	if (num <= 1) return num;
        // 	else return fibonacci(num - 1) + fibonacci(num - 2);
        // }
        double fibonacci_it(int num)
        {
            double a = 0;
            double b = 1;
            for (int i = 0; i < num; i++)
            {
                double temp = a; a = b; b += temp;
            }
            return a;
        }
    }
}
