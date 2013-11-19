﻿using Agathas.Storefront.Model.Categories;
using Agathas.Storefront.Model.Products;
using Agathas.Storefront.Services.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agathas.Storefront.Services
{
    public class AutoMapperBootStrapper
    {
        public static void ConfigureAutoMapper()
        {
            //Product Title and Product
            Mapper.CreateMap<ProductTitle, ProductSummaryView>();
            Mapper.CreateMap<ProductTitle, ProductView>();
            Mapper.CreateMap<Product, ProductSummaryView>();
            Mapper.CreateMap<Product, ProductSizeOption>();

            //Category
            Mapper.CreateMap<Category, CategoryView>();

            //IProductAttribute
            Mapper.CreateMap<IProductAttribute, Refinement>();

            //Global Money Formatter
            Mapper.AddFormatter<MoneyFormatter>();
        }
    }

    public class MoneyFormatter : IValueFormatter
    {
        public string FormatValue(ResolutionContext context)
        {
            if (context.SourceValue is decimal)
            {
                decimal money = (decimal)context.SourceValue;
                return money.ToString();//.FormatMoney();
            }
            return context.SourceValue.ToString();
        }
    }

}