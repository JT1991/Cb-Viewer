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
                    SeriesTitle = "The Absolute Sandman",
                    IssueTitle = "Preludes and Nocturnes",
                    IssueNumber = 1,
                    DescriptionHtml = @" <p>New York Times best-selling author Neil Gaiman's transcendent series SANDMAN is often hailed as the definitive
                                        Vertigo title and one of the finest achievements in graphic storytelling. Gaiman created an unforgettable tale of the forces that exist beyond life and death
                                        by weaving ancient mythology, folklore and fairy tales with his own distinct narrative vision. In PRELUDES & NOCTURNES, an occultist attempting to capture Death
                                        to bargain for eternal life traps her younger brother Dream instead. After his 70 year imprisonment and eventual escape, Dream, also known as Morpheus, goes on a
                                        quest for his lost objects of power. On his arduous journey Morpheus encounters Lucifer, John Constantine, and an all-powerful madman.
                                        This book also includes the story 'The Sound of Her Wings,' which introduces us to the pragmatic and perky goth girl Death.
                                        Includes issues 1-8 of the original series. ",
                    Artists = new Artist[]
                    {
                        new Artist() {Name = "Neil Gaiman", Role="Author" },
                        new Artist() {Name = "Sam Kieth", Role="Illustrator" },
                        new Artist() {Name = "Mike Dringenberg", Role="Illustrator" },
                        new Artist() {Name = "Malcolm Jones", Role="Illustrator" },
                        new Artist() {Name = "Todd Klein", Role="Letterer" },
                        new Artist() {Name = "Karen Berger", Role="Editor" },
                    }
            };
            return View(comicBook);
        }
    }
}