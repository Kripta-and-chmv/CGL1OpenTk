﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmpGrfLAB1
{
    class points
    {
         //Point's coordinates
        public int x { get; set; }
        public int y { get; set; }

        //Point's color
       
        public int red { get; set; }
        public int green { get; set; }
        public int blue { get; set; }

        
        public points(int x_, int y_, int red_, int green_, int blue_)
        {
            x = x_;
            y = y_;
            red = red_;
            green = green_;
            blue = blue_;
              
        }
    }
}
