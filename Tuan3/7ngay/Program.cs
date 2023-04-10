using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhập vào một số từ 2 đến 8: ");
        int number = int.Parse(Console.ReadLine());

        switch (number)
        {
            case 2:
                Console.WriteLine("Thứ hai");
                break;
            case 3:
                Console.WriteLine("Thứ ba");
                break;
            case 4:
                Console.WriteLine("Thứ tư");
                break;
            case 5:
                Console.WriteLine("Thứ năm");
                break;
            case 6:
                Console.WriteLine("Thứ sáu");
                break;
            case 7:
                Console.WriteLine("Thứ bảy");
                break;
            case 8:
                Console.WriteLine("Chủ nhật");
                break;
            default:
                Console.WriteLine("Số bạn nhập không hợp lệ.");
                break;
        }
    }
}
