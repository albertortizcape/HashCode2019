﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSlideshow2019.Entities
{
    public class Slide
    {
        public List<Photo> Photos { get; set; }

        public List<string> Tags { get; set; }
    }
}
