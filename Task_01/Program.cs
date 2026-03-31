namespace Task_01
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введіть перше число:");
            double arg1 = double.Parse(Console.ReadLine());
            Console.Write("Введіть друге число:");
            double arg2 = double.Parse(Console.ReadLine());
            Console.WriteLine(
                $"{arg1}+{arg2}={arg1+arg2}" +
                $"\n{arg1}-{arg2}={arg1 - arg2}" +
                $"\n{arg1}*{arg2}={arg1 * arg2}" +
                $"\n{arg1}/{arg2}={arg1 / arg2}" +
                $"\n{arg1}%{arg2}={arg1 % arg2}");

        }
    }
}