using Microsoft.AspNetCore.Mvc;
using PersonelYonetim.Models;

namespace PersonelYonetim.Controllers
{
    public class KayitController : Controller
    {
        Context c=new Context();
        [HttpGet]
        public IActionResult KayitYap()
        {
            return View();
        }
        [HttpPost]
        public IActionResult KayitYap(Models.Kayit k)
        {
            c.kayits.Add(k);
            c.SaveChanges();
            return View();

        }
    }
}
