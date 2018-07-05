using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationAga.Controllers
{
    public class HomeController : Controller
    {
      private  IList<Comment> ll= new List<Comment>()   {
            new Comment() { Name="Ana",  Text="Lorem Ipsum "},
           new Comment() { Name="Sara",  Text="It was  about something"},
           new Comment() { Name="Sara", Text="It was  about something"},
    };
        [HttpGet]
        public ActionResult Index(int? id)
        {
            id=(id!=null)?id:0;
            for(int i = 0; i < DiffImg.A.Length; i++)
            {
                string j= DiffImg.A[i];
                ViewData[i.ToString()] = j;
            }
            // Interaction.StreamingW();
            ViewData["p"] = id;

            Interaction.StreamingR();


            int a = (int) ViewData["p"];

            return View(Interaction.llll);

        }
        [HttpGet]
        public ActionResult NewComment()
        {

            return View();
        }
        [HttpPost]
        public ActionResult NewComment([Bind]Comment cm)
        {
            cm.ImagePath = (cm.ImagePath != "") ? cm.ImagePath :DiffImg.A[new Random().Next(0, 4)] ; 
            Interaction.llll = new List<Comment> { };
            Interaction.llll.Add(cm);
            Interaction.StreamingW();
            return RedirectToAction(nameof(Index));
;
        }

      
    }
}