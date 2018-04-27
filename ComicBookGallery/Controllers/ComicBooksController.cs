using ComicBookGallery.Models;
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
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Absolute Sandman, Vol. 1 ",
                IssueNumber = 1,
                DescriptionHtml = @" <p>Reprinting Sandman issues #1-20. With more than 65 pages of bonus material, 
                        including the original proposal for the series and the full script and pencil
                        art for issue 19. <strong>Released October 11, 2006.</strong> ",
                Artists = new Artist[]
                {
                    new Artist() {Name = "Neil Gaiman", Role="Creator" },
                    new Artist() {Name = "Sam Kieth", Role="Illustrator" },
                    new Artist() {Name = "Mike Dringenberg", Role="Illustrator" },
                    new Artist() {Name = "Charles Vess", Role="Illustrator" },
                    new Artist() {Name = "Michael Zulli", Role="Illustrator" },
                    new Artist() {Name = "Kelley Jones", Role="Illustrator" },
                    new Artist() {Name = "Chris Bachalo", Role="Illustrator" },
                    new Artist() {Name = "Malcolm Jones", Role="Illustrator" },
                    new Artist() {Name = "Danny Vozzo", Role="Illustrator" },
                    new Artist() {Name = "Colleen Doran", Role="Illustrator" }
                }
            };

            return View(comicBook);
        }
    }
}