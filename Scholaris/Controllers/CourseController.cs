using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Scholaris.Models;
using Scholaris.Services;

namespace Scholaris.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourse _Course;

        public CourseController(ICourse Course)
        {
            _Course = Course;
        }

        public IActionResult Index()
        {
            return View(_Course.GetCourses);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Course model)
        {
            if (ModelState.IsValid)
            {
                _Course.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Delete(int? Id)
        {
            if (Id == null)
            {

            }
            else
            {
                _Course.Remove(Id);
                return RedirectToAction("Index");
            }
            return View();
        }

        //public IActionResult Delete(int? Id)
        //{
        //    if (Id == null)
        //    {
        //        //Written by Reza: Error Handling
        //        return NotFound();
        //    }
        //    else
        //    {
        //        Course model = _Course.GetCourse(Id);
        //        return View(model);
        //    }
        //}
        //[HttpPost, ActionName("Delete")]
        //public IActionResult DeleteConfirm(int? Id)
        //{
        //    _Course.Remove(Id);
        //    return RedirectToAction("Index");
        //}



    }
}