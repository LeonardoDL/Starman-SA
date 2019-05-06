using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StarmanCRUD.Models;

namespace StarmanCRUD.Controllers
{
    public class ItemsController : Controller
    {
        // GET: Items/Random
        public ActionResult Random()
        {
            var item = new Item() { Name = "Pineapple" };
            return View(item);
        }
    }
}