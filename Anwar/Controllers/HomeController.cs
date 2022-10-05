using Anwar.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Anwar.Controllers
{
    public class HomeController : Controller
    {
        private readonly StudentDBContext _DBcontext;

        public HomeController(StudentDBContext logger)
        {
            _DBcontext = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            int pagenumber = 1;
            int pagesize = 10;

            string str = "https://jsonplaceholder.typicode.com/posts";

            using (HttpClient client =new HttpClient() )
            {
                HttpResponseMessage message = new HttpResponseMessage();

                message = client.GetAsync(str).Result;
                if(message.IsSuccessStatusCode)
                {
                    var data = message.Content.ReadAsStringAsync().Result;

                    var outObject = JsonConvert.DeserializeObject<List<LiveData>>(data);

                    var viewdata = outObject.Skip(pagesize *  (pagenumber-1)).Take(pagesize);

                    //foreach (var item in viewdata)
                    //{
                    //    LiveData live = new LiveData()
                    //    {

                    //        id = item.id,
                    //        userId = item.userId,
                    //        body = item.body,
                    //        title = item.title
                    //    };
                    //    _DBcontext.liveDatas.Add(live);
                    //    _DBcontext.SaveChanges();


                    //}

                    return View(viewdata);
                }
                else
                {

                    return null;
                }

            }

            
        }

        [HttpGet]
        public IActionResult ListStudent()
        {
            var ListOfStudent = _DBcontext.students.ToList();

            return View(ListOfStudent);
        }


        public IActionResult Logout()
        {
            ViewBag.data = HttpContext.Session.GetString("Email");

           
                HttpContext.Session.Remove("Email");
            

            return RedirectToAction("Index", "Home");
        }


        public  IActionResult Regstration(Student student)
        {
            
                if(student.ID!=null)
                {
                    Student student1 = new Student();
                    //student1.ID = student.ID;
                    student1.FName = student.FName;
                    student1.LName = student.LName;
                    student1.FatherName = student.FatherName;
                    student1.Email = student.Email;
                    student1.Passwords = "123456";
                    student1.Pincode = student.Pincode;
                    student1.Address = student.Address;
                    _DBcontext.students.Add(student1);

                    var a = _DBcontext.SaveChanges();

                    if (a > 0)
                    {
                         return View("Login1");

                    }

            }
            return View();

           // return View();
        }



        public IActionResult Edit( string id)
        {
            var getdata = _DBcontext.students.Where(x => x.ID.Equals(id)).FirstOrDefault();
            

            return View(getdata);

        }

        public IActionResult EditDataOfStudent(Student student)
        {
            var EditData = _DBcontext.students.Where(x => x.ID.Equals(student.ID)).FirstOrDefault();
            if(EditData!=null)
            {
                EditData.FatherName = student.FatherName;
                EditData.Address = student.Address;
                EditData.Passwords = student.Passwords;
                EditData.Email = student.Email;
                EditData.LName = student.LName;
                EditData.FName = student.FName;
                EditData.Pincode = student.Pincode;

               _DBcontext.SaveChanges();

                

                // RedirectToAction("Edit");

            }

            return RedirectToAction("ListStudent", "Home"); 
           

        }



        public  IActionResult Details(string id)
        {
            var data = _DBcontext.students.FirstOrDefault(x=>  x.ID.Equals(id));
            return View(data);
        }

        public IActionResult Delete(string id)
        {
            var delete = _DBcontext.students.Where(x => x.ID.Equals(id)).FirstOrDefault();
                _DBcontext.students.Remove(delete);
               _DBcontext.SaveChanges();
            
                return RedirectToAction("ListStudent", "Home");




        }


        //Logout

        public IActionResult Login1(Login login)
        {
           
            if (login.Email!=null && login.Passwords!=null)
            {
                var checkExit = _DBcontext.students.Where(x => x.Email == login.Email && x.Passwords == login.Passwords).Any();
                //var checkExit = _DBcontext.students.FirstOrDefault(x => x.Email == login.Email && x.Passwords == login.Passwords);


                if (checkExit==true)
                {
                    string email = string.Empty;
                    
                    if(HttpContext.Request.Cookies.ContainsKey("Email"))
                    {

                        string datr = HttpContext.Request.Cookies["Email"];
                        email = "Firsttimedata" + datr;

                        ViewBag.data = HttpContext.Session.GetString("Email");
                        return View("Index", email);
                       // HttpContext.Session.Keys
                        
                    }

                    else
                    {
                        string data = "FirstTime";

                        HttpContext.Response.Cookies.Append("Email", login.Email);
                        HttpContext.Session.SetString("Email",login.Email);
                        return View("Index", data);

                    }
                    
                }
                
            }
           return View();
        }

    }
}
