internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите x: ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Введите кол-во итераций");
        int iters = int.Parse(Console.ReadLine());
        double res = 0;
        if (iters > 0) res += Math.Sin(x);
        for (int i = 1; i < iters; i++)
        {
            int temp = 2;
            res += (Math.Cos(temp * x) / temp);
        }
        Console.WriteLine(res);
    }
}