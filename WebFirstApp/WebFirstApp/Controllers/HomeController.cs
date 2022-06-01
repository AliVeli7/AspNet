using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebFirstApp.Models;

namespace WebFirstApp.Controllers
{
    public class HomeController:Controller
    {
        private List<Students> students;

        public HomeController()
        {
            students = new List<Students>()
            {
                new Students{Id=1, Name="Ali",SurName="Valiyev"},
                new Students{Id=2, Name="Vali",SurName="Aliyev"},
                new Students{Id=3, Name="Emily",SurName="Agayeva"},
                new Students{Id=4, Name="Jane",SurName="Eyre"},

            };
        }

        public ViewResult Index(int? id)
        {
            if (id==null)
            {
                return View(students);
            }

            foreach (var item in students)
            {
                if (item.Id==id)
                {
                    return View(item);
                }
            }
            return View(students);

        }
       
        //public ViewResult index ()
        //{
        //    ViewResult view = new ViewResult();
        //    view.ViewName = "index";
        //    return view;
        //}


        //public IActionResult index()
        //{
        //    ViewBag.mesaj = "Salam ";
        //    ViewData["mesaj"] = "Necesen";
        //    TempData["mesaj"] = "Yaxsi";
        //    return View();
        //}

        //public IActionResult Index1(int? id)
        //{
        //    Students std = new Students();
        //    std.Id = 1;
        //    std.Name = "Ali";
        //    std.SurName = "CODE1";
        //    Students std1 = new Students();
        //    std1.Id = 2;
        //    std1.Name = "Ali";
        //    std1.SurName = "CODE2";
        //    Students std2 = new Students();
        //    std2.Id = 3;
        //    std2.Name = "Ali";
        //    std2.SurName = "CODE3";
        //    Students std3 = new Students();
        //    std3.Id = 4;
        //    std3.Name = "Ali";
        //    std3.SurName = "CODE4";

        //    Students.student.Add(std1);
        //    Students.student.Add(std);
        //    Students.student.Add(std2);
        //    Students.student.Add(std3);

        //    foreach (var item in Students.student)
        //    {
        //        if (item.Id==id)
        //        {

        //            return View(item);
        //        }
        //    }
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult index1(Students std)
        //{
        //    return View();
        //}
    }
}
