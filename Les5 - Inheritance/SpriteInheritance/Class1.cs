﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Eindopdracht
{
    class Sprite2 : Sprite
    {
        public Sprite2(RectangleF screenPosition)
        {
            this.screenPosition = screenPosition;
            imageFrame = new Rectangle(95, 199, 16, 16);
        }
    }
}
