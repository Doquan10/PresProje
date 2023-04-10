using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PresProje.Models;
using System;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PresProje.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        Context c = new Context();
        
        public IActionResult Index()
        {
            //Kullanıcı Adı
            var name = c.Users.Where(x=> x.Username == User.Identity.Name).Select(y => y.Username).FirstOrDefault();
            ViewBag.Name = name;

            //Hat'a göre pres listelenmesi
            var pres_list = c.HAT_PRES.Where(x => x.Hat == User.Identity.Name).Select(y => y.Pres).ToList();
            ViewBag.Pres = pres_list;



            var date = DateTime.Now.ToString("yyyy-MM-dd");
       
            var item = c.deneme_pres.Where(x => x.URETIM_TARIH == date).ToList();
            return View(item);
        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("SignIn","Login");
        }


        public JsonResult Add([FromBody] List<deneme_pres> names)
        {

            //Truncate Table to delete all old records.

            if (names == null)
            {
                names = new List<deneme_pres>();
            }
            foreach (var item in names)
            {
                if (item.PARCA_NO != null)
                {
                    c.deneme_pres.Add(item);

                }
            }
            int insertedRecords = c.SaveChanges();

            return Json(insertedRecords);
        }

        [HttpPost]
        public JsonResult AutoCompleteParca(string prefix)
        {
            var PARCA_NO = (from parca_no in this.c.PARCA_LISTESI
                            where parca_no.Malzeme.StartsWith(prefix)
                            select new
                            {
                                label = parca_no.Malzeme,
                                val = parca_no.Malzeme
                            }).Take(20).ToList();
            return Json(PARCA_NO);
        }

        [HttpPost]
        public JsonResult AutoCompleteHataTanimi(string prefix)
        {
            var HATA_TANIM = (from hata_tanim in this.c.Hata_Listesi
                            where hata_tanim.HataKodu.StartsWith(prefix)
                            select new
                            {
                                label = hata_tanim.HataTanimi

                            }).FirstOrDefault();
           
                return Json(HATA_TANIM);
           
        }


    }
}