using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Drawing2D;
using Teknokent2.Models;

namespace Teknokent2.Controllers
{
    
    public class TeacherController : Controller
    {

        private readonly Context context;

        public TeacherController(Context context)
        {
            this.context = context;
        }

        // GET: TeacherController
        public ActionResult Index()
        {
          var data=  context.Teachers.ToList();
            return View(data);
        }

        // GET: TeacherController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TeacherController/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: TeacherController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Teacher teacher)
        {
            try
            {
                //context.Teachers.Add(teacher);//buda ekleme
                //context.SaveChanges();
                context.Attach<Teacher>(teacher);//buda ekleme
                context.SaveChanges();
                return  RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TeacherController/Edit/5
        public ActionResult Edit(int id)
        {
            var verigetir = context.Teachers.Find(id);
            return View(verigetir);
        }

        // POST: TeacherController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Teacher teacher)
        {
            try
            {
                context.Teachers.Update(teacher);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var verigetir=context.Teachers.Find(id);
            return View(verigetir);
        }

        // POST: TeacherController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Teacher teacher)
        {
            try
            {
                context.Teachers.Remove(teacher);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
