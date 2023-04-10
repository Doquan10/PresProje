using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PresProje.Models;

namespace PresProje.Controllers
{
    [Authorize(Roles = "Admin")]
  
    public class AdminController : Controller
    {
        Context c = new Context();

        public IActionResult Index(int pg =1)
        {
            List<PRES_PROD> pres_prod = c.PRES_PROD.ToList();
            const int pageSize = 100;
            if (pg < 1)
                pg = 1;

            int recsCount = pres_prod.Count;
            var pager = new Pager(recsCount, pg, pageSize);
            int recSkip = (pg-1) * pageSize;

            var data = pres_prod.Skip(recSkip).Take(pageSize).ToList();
            this.ViewBag.Pager = pager;
            return View(data);
           
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {

            var data = c.PRES_PROD.Where(x=> x.ID == id).FirstOrDefault();
            return PartialView("_EditModalPartial",data);
        }


        [HttpPost]
        public IActionResult Edit(PRES_PROD dnm)
        {
            c.PRES_PROD.Update(dnm);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var data = c.PRES_PROD.Where(x => x.ID == id).FirstOrDefault();
            return PartialView("_DeleteModalPartial", data);
        }

        [HttpPost]
        public IActionResult Delete(PRES_PROD dnm)
        {
            var data = c.PRES_PROD.Where(x => x.ID == dnm.ID).FirstOrDefault();
            c.PRES_PROD.Remove(data);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

       
    }
}
