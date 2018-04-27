using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ComicBookGallery.Models;

namespace ComicBookGallery.Data
{
    public class ComicBookRepository
    {
        private static ComicBook[] _comicBooks = new ComicBook[]
            {
                new ComicBook()
                {
                    Id = 1,
                    SeriesTitle = "Sandman",
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
                },
                 new ComicBook()
                {
                    Id = 2,
                    SeriesTitle = "Sandman",
                    IssueTitle = "The Doll's House",
                    IssueNumber = 2,
                    DescriptionHtml = @" A being who has existed since the beginning of the universe, Dream of the Endless rules over the realm of dreams. In THE DOLL’S HOUSE, after a decades-long imprisonment, 
                                        the Sandman has returned to find that a few dreams and nightmares have escaped to reality. Looking to recapture his lost possessions, Morpheus ventures to the human plane 
                                        only to learn that a woman named Rose Walker has inadvertently become a dream vortex and threatens to rip apart his world. Now as Morpheus takes on the last escaped nightmare 
                                        at a serial killers convention, the Lord of Dreams must mercilessly murder Rose or risk the destruction of his entire kingdom. ",
                    Artists = new Artist[]
                    {
                        new Artist() {Name = "Neil Gaiman", Role="Author" },
                        new Artist() {Name = "Steve Parkhouse ", Role="Illustrator" },
                        new Artist() {Name = "Mike Dringenberg", Role="Illustrator" },
                        new Artist() {Name = "Chris Bachalo", Role="Illustrator" },
                        new Artist() {Name = "Malcolm Jones", Role="Illustrator" },
                        new Artist() {Name = "Todd Klein", Role="Letterer" },
                        new Artist() {Name = "Clive Barker", Role="Introduction" },
                    }
                },
            };

        public ComicBook GetComicBook(int id)
        {
            ComicBook comicBookToReturn = null;
            foreach (var comicBook in _comicBooks)
            {
                if (comicBook.Id == id)
                {
                    comicBookToReturn = comicBook;
                    break;
                }
            }
            return comicBookToReturn;
        }

        public ComicBook[] GetComicBooks()
        {
            return _comicBooks;
        }
    }
}
