﻿using Agathas.Storefront.Model.Categories;
using Agathas.Storefront.Services.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agathas.Storefront.Services.Mapping
{
    public static class CategoryMapper
    {
        public static IEnumerable<CategoryView> ConvertToCategoryViews(this IEnumerable<Category> categories)
        {
            return Mapper.Map<IEnumerable<Category>, IEnumerable<CategoryView>>(categories);
        }
    }
}
