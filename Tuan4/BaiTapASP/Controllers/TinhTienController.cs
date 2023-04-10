using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTapASP.Controllers
{
    public class TinhTienController : Controller
    {
        // GET: TinhTien
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TinhTienLinh()
        {
            return View();
        }
        public ActionResult XuLy()
        {
            String manv = Request["id"];
            ViewBag.id = manv;
            Double ngaylv = Convert.ToDouble(Request["sum"]);
            ViewBag.day = ngaylv;
            Double bacLuong = Convert.ToDouble(Request["salary"]);
            Double phuCap = 0;
            String cv = Convert.ToString(Request["level"]);
            //ngay tinh cong
            Double NCTL = 0;
            if(ngaylv < 25)
            {
                NCTL = ngaylv;
            }
            else
            {
                NCTL = (ngaylv - 25) * 2 + 25;
            }
            //cấp bậc
            if(cv.Contains("Trưởng phòng"))
            {
                phuCap = 500000;
            }if(cv.Contains("Phó phòng"))
            {
                phuCap = 300000;
            }
            Double tienLinh = bacLuong * 650000 * NCTL + phuCap;
            ViewBag.tong = tienLinh;
            //ViewBag.cvu = cv;
            return View();
        }
    }
}