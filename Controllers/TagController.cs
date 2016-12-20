using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBlog.Models;

namespace MvcBlog.Controllers
{
    public class TagController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult ListPostsByTag(int id)
        {
            var db = new ApplicationDbContext();

            var posts = db.Posts.Where(p => p.Tags.Any(x => x.ID == id));

            return View(posts.Include(p=>p.Author));
        }
    }
}