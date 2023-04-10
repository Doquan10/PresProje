using Microsoft.AspNetCore.Mvc;
using PresProje.Models;

namespace PresProje.Controllers
{
    public class DenemeController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var item = c.Deneme.ToList();
            return View(item);
        }

        public JsonResult Add([FromBody] List<Deneme> names)
        {

            //Truncate Table to delete all old records.

            if (names == null)
            {
                names = new List<Deneme>();
            }
            foreach (var item in names)
            {
                if (item.Name != null)
                {
                    c.Deneme.Add(item);

                }
            }
            int insertedRecords = c.SaveChanges();

            return Json(insertedRecords);
        }
    }
}
