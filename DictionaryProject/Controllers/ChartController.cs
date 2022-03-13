using DataAccess.Concrete;
using MvcProject.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class ChartController : Controller
    {
        public ActionResult Index()//Index üzerinde CategoryChart() çağıracağız
        {
            return View();
        }
        public ActionResult CategoryChart()
        {
            return Json(BlogList(), JsonRequestBehavior.AllowGet);
            //CategoryChart() çağrıldığında BlogList() dönücek 
        }
        public List<CategoryHeading> BlogList()
        {
            List<CategoryHeading> categoryHeadings = new List<CategoryHeading>();
            using (var context = new Context())
            {
                categoryHeadings = context.Categories.Select(c => new CategoryHeading
                {
                    CategoryName = c.CategoryName,
                    CategoryCount =c.Headings.Count()
                }).ToList();
            }
            return categoryHeadings;
        }
        public ActionResult WriterIndex()
        {
            return View();
        }
        public ActionResult WriterChart()
        {
            return Json(WriterHeadingCount(), JsonRequestBehavior.AllowGet);
        }      
        public List<WriterHeading> WriterHeadingCount()
        {
            List<WriterHeading> writerHeadings = new List<WriterHeading>();
            using (var context = new Context())
            {
                writerHeadings = context.Writers.Select(w => new WriterHeading
                {
                    WriterName = w.WriterFirstName,
                    HeadingCount = w.Headings.Count()
                }).ToList();
            }
            return writerHeadings;
        }
    }
}
