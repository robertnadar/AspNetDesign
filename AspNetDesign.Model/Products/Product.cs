﻿using AspNetDesign.Infrastructure.Domain;
using AspNetDesign.Model.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetDesign.Model.Products
{
    public class Product : EntityBase<int>, IAggregateRoot
    {
        public ProductSize Size { get; set; }
        //public ProductColor Color {  set; }
        public ProductTitle Title { get; set; }

        public string Name
        {
            get
            {
                return Title.Name;
            }
        }

        public decimal Price
        {
            get
            {
                return Title.Price;
            }
        }

        public Brand Brand
        {
            get
            {
                return Title.Brand;
            }
        }

        public ProductColor Color
        {
            get {
                return Title.Color;
            }
        }

        public Category Category
        {
            get { return Title.Category; }
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }

    }
}
