﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS.WebApi.Infrastructure.Features.Product.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }

    }
}
