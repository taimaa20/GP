﻿using System;
using System.Collections.Generic;

namespace WebApplication28.Models
{
    public partial class AboutU
    {
        public int AboutUsId { get; set; }
        public string AboutImage { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
