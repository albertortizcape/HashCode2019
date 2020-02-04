using PhotoSlideshow2019.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSlideshow2019
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Photo> photos = new List<Photo>();

            int numPhotos = int.Parse(args[0]);

            for(int i = 1; i <= numPhotos; i++)
            {
                Photo photo = new Photo();
                photo.GetValuesFromInput(i, args[numPhotos]);

                photos.Add(photo);
            }

            Scoring scoring = new Scoring();
            Slideshow slideshow = scoring.GetSlideshowFromPhotos(photos);

            string resultado = slideshow.GetSliedesResult();
        }
    }
}
