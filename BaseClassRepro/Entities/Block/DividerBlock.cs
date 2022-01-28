﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BaseClassRepro.Entities.Enums;

namespace BaseClassRepro.Entities.Block
{
    public class DividerBlock : Block
    {
        public DividerType DividerType { get; set; }
        public DividerLength DividerLength { get; set; }
    }
}
