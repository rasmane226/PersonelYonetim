using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using PersonelYonetim.Models;
using Microsoft.AspNetCore.Authorization;

namespace PersonelYonetim.Controllers
{
    public class LoginController : Controller
    {
        
        Context c=new Context();
        [AllowAnonymous]
        [HttpGet]
        public IActionResult GirisYap()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GirisYap(Admin loginModel)
        {
            var datavalue = c.admins.FirstOrDefault(x => x.Kullanici == loginModel.Kullanici
           && x.Sifre == loginModel.Sifre);
            if (datavalue !=null)
            {
                var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, loginModel.Kullanici)
            };

                var userIdentity = new ClaimsIdentity(claims, "Login");

                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);

                //Just redirect to our index after logging in. 
                return RedirectToAction("Index", "Personel");
            }
            return View();
        }
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("Index");
        }

       

    }



}
