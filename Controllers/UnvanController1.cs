using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using PersonelYonetim.Models;
using System.Linq;
using System.Threading.Tasks;
namespace PersonelYonetim.Controllers
{
    
    public class UnvanController1 : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var data=c.Unvans.ToList();
            return View(data);
        }
        [HttpGet]
        public IActionResult YeniUnvan()
        {

            return View(); 
        }
        [HttpPost]
        public IActionResult YeniUnvan(Unvan u)
        {
            c.Unvans.Add(u);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Unvansil(int id)
        {
            var unvan = c.Unvans.Find(id);
           
            if(unvan!=null)
            {
                c.Unvans.Remove(unvan);
                c.SaveChanges();
                return RedirectToAction("index");
            }
            else
            {
                return View();
            }
            
        }
        public IActionResult Unvangetir(int id)
        {

            var un = c.Unvans.Find(id);
            return View("Unvangetir", un);
        }
        public IActionResult Unvanguncelle(Unvan u)
        {

            var un = c.Unvans.Find(u.id);
            if(un!=null)
            {
                un.unvanad = u.unvanad;
                un.personelid = u.personelid;

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
