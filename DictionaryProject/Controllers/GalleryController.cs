using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class GalleryController : Controller
    {
        ImageFileManager imageFileManager = new ImageFileManager(new EfImageFileDal());
        public ActionResult Index()
        {
            var imageValues = imageFileManager.GetAll();
            return View(imageValues);
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(ImageFile imageFile)
        {
            imageFileManager.Add(imageFile);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var imageValue = imageFileManager.GetById(id);
            imageFileManager.Delete(imageValue);
            return RedirectToAction("Index");
        }
        public ActionResult Update(ImageFile imageFile)
        {
            imageFileManager.Update(imageFile);
            return RedirectToAction("Index");
        }        
    }
}
