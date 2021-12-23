using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebECom.Models;
using WebECom.ViewModel;

namespace WebECom.App_Start
{
    public class MapperConfig
    {
        public static MapperConfiguration Configure()
        {
            MapperConfiguration mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CategoryViewModel, Category>();
                cfg.CreateMap<Category, CategoryViewModel>().AfterMap((src, dest) =>
                {
                    dest.ParentCategoryName = src.Parent == null ? "" : src.Parent.Title;
                });

                cfg.CreateMap<ProductViewModel, Product>();
                cfg.CreateMap<Product, ProductViewModel>().AfterMap((src, dest) =>
                {
                    dest.CategoryName = src.Category == null ? "" : src.Category.Title;
                });
            });

            return mapperConfiguration;
        }
    }
}
