using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class AuthorizationController : Controller
    {
        AdminManager adminManager = new AdminManager(new EfAdminDal());
        RoleManager roleManager = new RoleManager(new EfRoleDal());
        public ActionResult Index()
        {
            var adminValues = adminManager.GetAll();
            return View(adminValues);
        }
        [HttpGet]
        public ActionResult AddAdmin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAdmin(Admin admin)
        {
            adminManager.Add(admin);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            List<SelectListItem> valueadminrole = (from c in roleManager.GetAll()
                                                   select new SelectListItem
                                                   {
                                                       Text = c.RoleName,
                                                       Value = c.RoleId.ToString()

                                                   }).ToList();

            ViewBag.valueadmin = valueadminrole;
            var adminValue = adminManager.GetById(id);
            return View(adminValue);
        }
        [HttpPost]
        public ActionResult Update(Admin admin)
        {
            adminManager.Update(admin);
            return RedirectToAction("Index");
        }
        public ActionResult AdminStatusUpdate(int id)
        {
            var admin = adminManager.GetById(id);
            if (admin.AdminStatus)
            {
                admin.AdminStatus = false;
            }
            else
            {
                admin.AdminStatus = true;
            }
            adminManager.Update(admin);
            return RedirectToAction("Index");
        }
    }
}