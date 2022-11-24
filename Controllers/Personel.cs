using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using PersonelYonetim.Models;
using System.Linq;
using System.Threading.Tasks;
namespace PersonelYonetim.Controllers
{
    public class Personel : Controller
    {
        Context c = new Context();
       
        public IActionResult Index()
        {
            var data=c.personels.ToList();
            return View(data);
        }
        [HttpGet]
        public IActionResult Yenipersonel()
        {
            return View();  
        }
        [HttpPost]  
        public IActionResult YeniPersonel(Models.Personel p)
        {



                c.personels.Add(p);
                c.SaveChanges();
            return RedirectToAction("Index");
            
        }

        public IActionResult Personelsil(int id)
        {
            var personel = c.personels.Find(id);

            if (personel != null)
            {
                c.personels.Remove(personel);
                c.SaveChanges();
                return RedirectToAction("index");
            }
            else
            {
                return View();
            }
            

           

        }

        public IActionResult Personelgetir(int id)
        {

            var per = c.personels.Find(id);
            return View("Personelgetir", per);
        }
        public IActionResult Personelguncelle(Models.Personel p)
        {

            var per = c.personels.Find(p.id);
            if (per != null)
            {
                per.ad = p.ad;
                per.soyad = p.soyad;
                per.tel = p.tel;
                per.unvanid = p.unvanid;

                c.SaveChanges();
                return RedirectToAction("index");
            }

            else
            {
                return View();
            }
        }
    }
}
 