using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSlideshow2019.Entities
{
    public class Slideshow
    {
        public List<Slide> Slides { get; set; }

        public string GetSliedesResult()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Slides.Count);
            sb.Append("\n");

            foreach(Slide slide in Slides)
            {
                string photosInSlide = "";
                foreach(Photo photo in slide.Photos)
                {
                    photosInSlide += photo.InputOrder;
                    photosInSlide += " ";
                }

                if(photosInSlide.EndsWith(" "))
                {
                    photosInSlide.Substring(0, photosInSlide.Length - 1);
                }

                sb.Append(photosInSlide);

                sb.Append("\n");
            }

            return sb.ToString();
        }
    }
}
