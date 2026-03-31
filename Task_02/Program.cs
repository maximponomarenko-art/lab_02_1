namespace Task_02
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Оберіть операцію(1-'+',2-'-',3-'*',4-'/',5-'%'.):");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Введіть перше число:");
            double arg1 = double.Parse(Console.ReadLine());
            Console.Write("Введіть друге число:");
            double arg2 = double.Parse(Console.ReadLine());
            if (num == 1)Console.WriteLine($"{arg1}+{arg2}={arg1+arg2}");
            if (num == 2) Console.WriteLine($"{arg1}-{arg2}={arg1 - arg2}");
            if (num == 3) Console.WriteLine($"{arg1}*{arg2}={arg1 * arg2}");
            if (num == 4) Console.WriteLine($"{arg1}/{arg2}={arg1 / arg2}");
            if (num == 5) Console.WriteLine($"{arg1}%{arg2}={arg1 % arg2}");
        }
    }
}
