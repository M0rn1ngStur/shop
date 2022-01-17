﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wsei.Lab3.Models
{
    public class ProductStatsViewModel
    {
        public int NameLength { get; set; }

        public int DescriptionLength { get; set; }

        public double Price { get; set; }

        public IFormFile ProductImage {get; set;}
    }
}
