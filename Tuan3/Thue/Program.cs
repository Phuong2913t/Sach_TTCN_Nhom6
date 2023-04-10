using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap luong: ");
        int luong = int.Parse(Console.ReadLine());

        Console.Write("Nhap thuong: ");
        int thuong = int.Parse(Console.ReadLine());

        int thuNhap = luong + thuong;
        double thue = 0;

        if (thuNhap > 0 && thuNhap < 9000000)
        {
            thue = 0;
        }
        else if (thuNhap >= 9000000 && thuNhap < 15000000)
        {
            thue = 0.1 * thuNhap;
        }
        else if (thuNhap >= 15000000 && thuNhap < 30000000)
        {
            thue = 0.15 * thuNhap;
        }
        else
        {
            thue = 0.2 * thuNhap;
        }

        Console.WriteLine("Thu nhap: " + thuNhap);
        Console.WriteLine("Thue thu nhap: " + thue);
        Console.ReadLine();
    }
}
