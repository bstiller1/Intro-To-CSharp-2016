using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStoreNew.Models;

namespace MvcMusicStoreNew.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            return View();
        }
        // GET: /Store/Browse
        // GET: /Store/Browse?genre=Disco
        public string Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
            return message;
        }
        //
        // GET: /Store/Details
        public string Details()
        {
            return "Hello from Store.Details()";
        }
        // GET: /Store/Details/5
        public ActionResult Details(int id)
        {
            var album = new Album { Title = "Album " + id };
            return View(album);
        }
    }
}