﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetDesign.Services.ViewModels
{
    public class BasketItemView
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductSizeName { get; set; }
        public int ProductTitleId { get; set; }
        public int Qty { get; set; }
        public string ProductPrice { get; set; }
        public string LineTotal { get; set; }
    }
}
