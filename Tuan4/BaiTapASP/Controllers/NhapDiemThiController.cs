using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTapASP.Controllers
{
    public class NhapDiemThiController : Controller
    {
        // GET: NhapDiemThi
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult NhapDiem()
        {
            return View();
        }
        public ActionResult XuLy()
        {
            String hoTen = Request["name"];
            String loai = Request["type"];
            String ketqua = " ";
            String khuVuc = Convert.ToString(Request["address"]);
            double diemToan = Convert.ToDouble(Request["toan"]);
            double diemLy = Convert.ToDouble(Request["ly"]);
            double diemHoa = Convert.ToDouble(Request["hoa"]);
            double tong = diemToan + diemLy + diemHoa;
            if (loai != null)
            {
                tong = tong + 1;
            }
            if(tong >= 20)
            {
                ketqua = "Do dai hoc";
            }else if(tong >=15 && tong < 20)
            {
                ketqua = "Do cao dang";
            }
            else if (tong >= 10 && tong < 15)
            {
                ketqua = "Do trung cap";
            }
            else
            {
                ketqua = "Thi truot";
            }
            //diem cong khu vuc
            double diemCong = 0;
            if (khuVuc.Contains("Khu vuc A"))
            {
                diemCong = 1;
            }
            else if (khuVuc.Contains("Khu vuc B"))
            {
                diemCong = 2;
            }
            if (khuVuc.Contains("Khu vuc C"))
            {
                diemCong = 3;
            }
            tong = tong + diemCong;
            ViewBag.ten = hoTen;
            ViewBag.diachi = khuVuc;
            ViewBag.tong = tong;
            ViewBag.kq = ketqua;
            ViewBag.kv = khuVuc;
            return View();
        }
    }
}