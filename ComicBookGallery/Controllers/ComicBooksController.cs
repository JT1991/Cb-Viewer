using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {

            ViewBag.SeriesTitle = "The Absolute Sandman, Vol. 1 ";
            ViewBag.IssueNumber = 1;
            ViewBag.Description = @" <p>Reprinting Sandman issues #1-20. With more than 65 pages of bonus material, 
                        including the original proposal for the series and the full script and pencil
                        art for issue 19. <strong>Released October 11, 2006.</strong> ";
            ViewBag.Artists = new string[]
            {
                "by Neil Gaiman",
                "Sam Kieth (Illustrator)",
               " Mike Dringenberg (Illustrator)",
                "Charles Vess (Illustrator)",
                "Michael Zulli (Illustrator)",
               " Kelley Jones (Illustrator)",
                "Chris Bachalo (Illustrator)",
               " Malcolm Jones (Illustrator)",
               " Danny Vozzo (Illustrator)",
                "Colleen Doran (Illustrator)"
            };

            return View();
        }
    }
}