using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KHO.Models;

namespace KHO.Controllers
{
    public class KhoController : Controller
    {
        DbQLKhoDataContext db = new DbQLKhoDataContext();
        private List<MatHang> LayMatHang(int count)
        {
            return db.MatHangs.OrderByDescending(a => a.MaMH).Take(count).ToList();
        }
        // GET: Kho
        public ActionResult Index()
        {
            var mathang = LayMatHang(4);
            return View(mathang);
        }
    }
}