﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gui
{
    public class Mill
    {
        public bool isNew { get; set; }
        public int Id {get; set;}

        public int[] Positions { get; set; }

        public Mill(int[] Positions, int Id = -1)
        {
            this.Positions = Positions;
            isNew = false;
            this.Id = Id;
        }
    }
}
