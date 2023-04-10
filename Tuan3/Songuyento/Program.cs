using System;

class Program
{
    static bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    static void Main()
    {
        Console.WriteLine("Nhap day so can kiem tra: ");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        Console.Write("Cac so nguyen to trong day so la: ");
        foreach (string number in numbers)
        {
            int n;
            if (int.TryParse(number, out n) && IsPrime(n))
            {
                Console.Write(n + " ");
            }
        }
    }
}
