using MvcBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlog.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var db = new ApplicationDbContext();
            var posts = db.Posts.OrderByDescending(p => p.Date).Take(3);
            return View(posts.ToList());
        }

        public ActionResult _Post(int id)
        {
            
            Post post = db.Posts.Find(id);
            return PartialView(post);
        }

    }
}