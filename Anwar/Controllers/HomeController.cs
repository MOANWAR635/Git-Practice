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
using MailKit.Net.Smtp;
using MailKit;

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

        public IActionResult Privacy(int number)
        {


            if (number == 0)
            {
                number = 1;
            }
            int pagenumber = 1;
            int pagesize = 10;

            string str = "https://jsonplaceholder.typicode.com/posts";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage message = new HttpResponseMessage();

                message = client.GetAsync(str).Result;
                if (message.IsSuccessStatusCode)
                {
                    var data = message.Content.ReadAsStringAsync().Result;

                    var outObject = JsonConvert.DeserializeObject<List<LiveData>>(data);
                    var data1 = outObject.Count();

                    var viewdata = outObject.Skip(pagesize * (number - pagenumber)).Take(pagesize);

                    outObject.ForEach(x => x.Pagenumber = number);
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


        public IActionResult Regstration(Student student)
        {

            if (student.ID != null)
            {
                Student student1 = new Student();
                //student1.ID = student.ID;
                student1.FName = student.FName;
                student1.LName = student.LName;
                student1.FatherName = student.FatherName;
                student1.Email = student.Email;
                student1.Passwords = student.Passwords;
                student1.Pincode = student.Pincode;
                student1.Address = student.Address;
                _DBcontext.students.Add(student1);

                var a = _DBcontext.SaveChanges();

                if (a > 0)
                {
                    return RedirectToAction("ListStudent");

                }

            }
            return RedirectToAction("ListStudent");

            // return View();
        }



        public IActionResult Edit(string id)
        {
            var getdata = _DBcontext.students.Where(x => x.ID.Equals(id)).FirstOrDefault();


            return View(getdata);

        }

        public IActionResult EditDataOfStudent(Student student)
        {
            var EditData = _DBcontext.students.Where(x => x.ID.Equals(student.ID)).FirstOrDefault();
            if (EditData != null)
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



        public IActionResult Details(string id)
        {
            var data = _DBcontext.students.FirstOrDefault(x => x.ID.Equals(id));
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

            if (login.Email != null && login.Passwords != null)
            {
                var checkExit = _DBcontext.students.Where(x => x.Email == login.Email && x.Passwords == login.Passwords).Any();
                //var checkExit = _DBcontext.students.FirstOrDefault(x => x.Email == login.Email && x.Passwords == login.Passwords);


                if (checkExit == true)
                {
                    string email = string.Empty;

                    if (HttpContext.Request.Cookies.ContainsKey("Email"))
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
                        HttpContext.Session.SetString("Email", login.Email);
                        return View("Index", data);

                    }

                }

            }
            return View();
        }



        public IActionResult GetApplicantsList()
        {
            var getdata = _DBcontext.results.AsQueryable();
            var getid = getdata.Select(x => x.id).AsQueryable();
            string url = "https://api.ceipal.com/v1/getApplicantsList/";

            using (HttpClient client = new HttpClient())
            {
                Results results = new Results ();
                try
                {
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ1c2VyX2lkIjoyMjU1MTIsImV4cCI6MTY2NzQ4NjE1NCwiaWF0IjoxNjY3NDgyNTU0fQ.DvRVd_gicjfWTc1UUVf0kSYOSJDFlMgZ0quUHyQlmu4");
                    // client.DefaultRequestHeaders.Add("Content-Type", "application/json");
                    HttpResponseMessage message = new HttpResponseMessage();

                    message = client.GetAsync(url).Result;
                    if (message.IsSuccessStatusCode)
                    {
                        var data = message.Content.ReadAsStringAsync().Result;

                        var outObject = JsonConvert.DeserializeObject<GetApplicantsList>(data);
                        var data1 = outObject.results;
                        var getid2 = data1.Select(x => x.id).AsQueryable();
                       


                        // var data1 = outObject.Count();
                        foreach (var item in data1)
                        {
                            if(getid.Contains(item.id))
                            {
                                Results results1 = new Results();
                                results1.id = item.id;
                                results1.firstname = item.firstname;
                                results1.lastname = item.lastname;
                                results1.middlename = item.middlename;
                                results1.address = item.address;
                                results1.applicant_id = item.applicant_id;
                                results1.applicant_status = item.applicant_status;
                                results1.city = item.city;
                                results1.consultant_name = item.consultant_name;
                                results1.country = item.country;
                                results1.created_at = item.created_at;
                                results1.created_by = item.created_by;
                                results1.email = item.email;
                                results1.email_address_1 = item.email_address_1;
                                results1.home_phone_number = item.home_phone_number;
                                results1.job_title = item.job_title;
                                results1.resume_path = item.resume_path;
                                results1.work_phone_number = item.work_phone_number;
                                results1.other_phone = item.other_phone;
                                results1.skills = item.skills;
                                results1.source = item.source;

                                _DBcontext.results.Update(results1);

                            }
                            else
                            {
                                results.id = item.id;
                                results.firstname = item.firstname;
                                results.lastname = item.lastname;
                                results.middlename = item.middlename;
                                results.address = item.address;
                                results.applicant_id = item.applicant_id;
                                results.applicant_status = item.applicant_status;
                                results.city = item.city;
                                results.consultant_name = item.consultant_name;
                                results.country = item.country;
                                results.created_at = item.created_at;
                                results.created_by = item.created_by;
                                results.email = item.email;
                                results.email_address_1 = item.email_address_1;
                                results.home_phone_number = item.home_phone_number;
                                results.job_title = item.job_title;
                                results.resume_path = item.resume_path;
                                results.work_phone_number = item.work_phone_number;
                                results.other_phone = item.other_phone;
                                results.skills = item.skills;
                                results.source = item.source;

                                _DBcontext.results.Add(results);
                                
                            }
                           
                        }
                        _DBcontext.SaveChanges();

                        return View(data1);
                    }
                }
                catch (Exception ex)
                {

                    throw;
                }
                    //var viewdata = outObject.Skip(pagesize * (number - pagenumber)).Take(pagesize);

                    //outObject.ForEach(x => x.Pagenumber = number); 
                }
            return View();
        }

        public IActionResult GetClientData()
        {
            List<ReturnDataView> addData = new List<ReturnDataView>();
            string url = "https://api.ceipal.com/v1/getClientsList/";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ1c2VyX2lkIjoyMjU1MTIsImV4cCI6MTY2NzQ5NjEzNSwiaWF0IjoxNjY3NDkyNTM1fQ.ZpFe2AmaVxtUiny8Wp2BgD_RQNfXkYEdLrOaiYnSLiE");
                    HttpResponseMessage message = new HttpResponseMessage();
                    message = client.GetAsync(url).Result;
                        if (message.IsSuccessStatusCode)
                        {
                            var data = message.Content.ReadAsStringAsync().Result;
                            var serialization = JsonConvert.SerializeObject(data);
                            var show = JsonConvert.DeserializeObject<GetClientsList>(data);
                              var getData = show.results;

                       List<Results1> results = new List<Results1>();
                        results.AddRange(getData);
                        var getdata = _DBcontext.GetClientsData.AsQueryable();

                        var getid = getData.Select(x => x.id).AsQueryable();

                        
                        //List<ReturnDataView> UpdateData = new List<ReturnDataView>();

                        ReturnDataView returnDataView = new ReturnDataView();


                        foreach (var item in results)
                        {
                            if (getid.Contains(item.id))
                            {
                                _DBcontext.GetClientsData.UpdateRange(item);
                                // _DBcontext.SaveChanges();
                                returnDataView.id = item.id;
                                returnDataView.name = item.name;
                                returnDataView.state = item.state;
                                returnDataView.status = item.status;
                                returnDataView.created_at = item.created_at;
                                addData.Add(returnDataView);
                            }
                            if(!getid.Contains(item.id))
                            {
                                _DBcontext.GetClientsData.AddRange(results);
                                returnDataView.id = item.id;
                                returnDataView.name = item.name;
                                returnDataView.state = item.state;
                                returnDataView.status = item.status;
                                returnDataView.created_at = item.created_at;
                                addData.Add(returnDataView);


                            }
                        }

                        _DBcontext.SaveChanges();

                                           



                    }

                }
                catch (Exception ex)
                {

                    throw;
                }


            }

          return View(addData);

        }



    }

 }

