using FirstDimo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstDimo.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> students = new List<Student>();
        public ActionResult Index()
        {
            return View(students);
        }

        // GET: StudentController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student student)
        {
            try
            {
                students.Add(student);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
