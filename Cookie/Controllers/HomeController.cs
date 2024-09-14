using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cookie.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            // Create a cookie
            HttpCookie cookie = new HttpCookie("UserName");
            cookie.Value = "Mohammed Sufyan Rizvi";
            cookie.Expires = DateTime.Now.AddMinutes(1); // Cookie will expire in 1 day

            // Add the cookie to the response
            Response.Cookies.Add(cookie);

            return RedirectToAction("cookiee");
        }

        public ActionResult cookiee()
        {

            // Retrieve the cookie
            HttpCookie cookie = Request.Cookies["UserName"];
            string userName = cookie != null ? cookie.Value : "Guest";

            ViewBag.Message = "Welcome, " + userName;
            return View();
        }
    }
}