using System;
using System.Text;

namespace opp2
{
    class SinhVien
    {
        private string MASV;
        private string HoTen;
        private double DiemToan;
        private double DiemVan;
        private double DiemLy;
        public double diemLy
        {
            get { return DiemLy; }
            set { DiemLy = value; }
        }
        public double diemVan
        {
            get { return DiemVan; }
            set { DiemVan = value; }
        }
        public double diemToan
        {
            get { return DiemToan; }
            set { DiemToan = value; }
        }
        public string mASV
        {
            get { return MASV; }
            set { MASV = value; }
        }
        public string hoten
        {
            get { return HoTen; }
            set { HoTen = value; }
        }
        public void DTB()
        {
            Console.OutputEncoding = Encoding.UTF8;
            double DTBHS = (DiemLy + DiemToan + DiemVan) / 3;
            Console.WriteLine("\nMã số:" + MASV + "\nHọ tên:" + HoTen + "\nĐiểm Toán:" + DiemToan + "\nĐiểm Lý:" + DiemLy + "\nĐiểm Văn:" + DiemVan + "\nĐiểm trung bình:" + DTBHS);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            SinhVien SV1 = new SinhVien();
            SV1.mASV = "1029323";
            SV1.hoten = "NguyenVanA";
            SV1.diemVan = 10;
            SV1.diemLy = 10;
            SV1.diemToan = 10;
            SV1.DTB();
            Console.ReadKey(false);
        }
    }
}