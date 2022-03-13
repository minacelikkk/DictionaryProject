using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System.Web.Mvc;

namespace DictionaryProject.Controllers
{
    public class DraftController : Controller
    {
        DraftManager draftManager = new DraftManager(new EfDraftDal());
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetAllDraft()
        {
            var draftValues = draftManager.GetAll();
            return View(draftValues);
        }
        public ActionResult GetDraftDetails(int id)
        {
            var draftValue = draftManager.GetById(id);
            return View(draftValue);
        }
        public ActionResult GetDraftById(int id)
        {
            var draftValues = draftManager.GetById(id);
            return View(draftValues);
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Draft draft)
        {
            draftManager.Add(draft);
            return RedirectToAction("Index");
        }
    }
}