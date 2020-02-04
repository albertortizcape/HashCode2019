using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSlideshow2019.Entities
{
    public class Photo
    {
        public int InputOrder { get; internal set; }

        public Orientation Orientation { get; set; }

        public List<string> Tags { get; set; }

        internal void GetValuesFromInput(int order, string arg)
        {
            InputOrder = order;

            string[] delimiter = {" "};
            string[] input = arg.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

            if(input.Length >= 3)
            {
                SetOrientation(input[0]);
                SetTags(input);              
            }
            else
            {
                throw new Exception("Parámetros no válidos");
            }
            
        }

        private void SetTags(string[] input)
        {
            int numTags = int.Parse(input[1]);
            Tags = new List<string>();

            for (int i = 2; i < numTags + 2; i++)
            {
                Tags.Add(input[i]);
            }
        }

        private void SetOrientation(string v)
        {
            if (v.Equals("H"))
            {
                Orientation = Orientation.Horizontal;
            }
            else if (v.Equals("V"))
            {
                Orientation = Orientation.Vertical;
            }
            else
            {
                throw new Exception("Horientación no valida");
            }
        }
    }

    public enum Orientation
    {
        Vertical,
        Horizontal
    }
}
