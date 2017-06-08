using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using A_3a_oara_e_cu_noroc.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace A_3a_oara_e_cu_noroc.Controllers
{
    public class HomeController : Controller
    {
       
        private OurDbContext _context;
       
        public HomeController(OurDbContext context)
        {
            _context = context;
        }


        [HttpPost]
        public ActionResult Adauga(Iteme item)
        {
            if (!ModelState.IsValid)
            {
                return View(item);
            }
            _context.ElementeLista.Add(item);
            _context.SaveChanges();
            return View("Index", _context.ElementeLista.ToList());
            

        }



        [HttpPost]
        public ActionResult Sterge(Iteme n)
        {
            var original = _context.ElementeLista.FirstOrDefault(e => e.nume == n.nume);
            if(original!=null)

            _context.ElementeLista.Remove(original);
            _context.SaveChanges();
            return RedirectToAction("Index");


        }

        public IActionResult Adauga()
        {
            ViewData["Message"] = "";
           
            

            return View();

            
        }

        public IActionResult Sterge()
        {
            ViewData["Message"] = "";



            return View();


        }


        [HttpPost]
        public ActionResult SignIn(UserPw user)
        {
            var account = _context.UseriParole.Where(u => u.username == user.username && u.parola== user.parola).FirstOrDefault();
            if (account != null)
            {
                HttpContext.Session.SetString("UserID", account.UserID.ToString());
                HttpContext.Session.SetString("username", account.username);
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Username or password is wrong.");
            }
            return View();
        }

        public IActionResult LoginView()
        {
            return View();
        }

       


        public IActionResult Index()
        {
            
            return View("Index",_context.ElementeLista.ToList());

        }

       





        

        /*public ActionResult Login()
        {
            return View();
        }*/
        
        public ActionResult Welcome()
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                ViewBag.Username = HttpContext.Session.GetString("Username");
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        
        
    }
}
