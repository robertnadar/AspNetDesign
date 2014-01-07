﻿using AspNetDesign.Infrastructure.Configuration;
using AspNetDesign.Infrastructure.CookieStorage;
using AspNetDesign.Infrastructure.Domain;
using AspNetDesign.Infrastructure.Email;
using AspNetDesign.Infrastructure.Logging;
using AspNetDesign.Model.Basket;
using AspNetDesign.Model.Categories;
using AspNetDesign.Model.Products;
using AspNetDesign.Model.Shipping;
using AspNetDesign.Repository.NHibernat;
using AspNetDesign.Repository.NHibernat.Repositories;
using AspNetDesign.Services.Implementations;
using AspNetDesign.Services.Interfaces;
using StructureMap;
using StructureMap.Configuration.DSL;

namespace AspNetDesign.UI.Web.MVC
{
    public class BootStrapper
    {
        public static void ConfigureDependencies()
        {
            ObjectFactory.Initialize(x =>
            {
                x.AddRegistry<ControllerRegistry>();
            });
        }

        public class ControllerRegistry : Registry
        {
            public ControllerRegistry()
            {
                // Repositories
                For<IBasketRepository>().Use<BasketRepository>();
                For<IDeliveryOptionRepository>().Use<DeliveryOptionRepository>();
                For<ICategoryRepository>().Use<CategoryRepository>();
                For<IProductTitleRepository>().Use<ProductTitleRepository>();
                For<IProductRepository>().Use<ProductRepository>();

                For<IUnitOfWork>().Use<NHUnitOfWork>();

                // Product Catalogue
                For<IProductCatalogService>().Use<ProductCatalogService>();
                For<IBasketService>().Use<BasketService>();
                For<ICookieStorageService>().Use<CookieStorageService>();

                // Application Settings
                For<IApplicationSettings>().Use<WebConfigApplicationSettings>();
                
                // Logger
                For<ILogger>().Use<Log4NetAdapter>();
                
                // E-Mail Service
                For<IEmailService>().Use<TextLoggingEmailService>();
            }
        }
    }
}