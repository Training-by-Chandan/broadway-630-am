using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebECom.Models;
using WebECom.Repository;
using WebECom.ViewModel;

namespace WebECom.Services
{
    public interface IProductService
    {
        (bool, string, int) Create(ProductViewModel model);

        (bool, string, int) Edit(ProductViewModel model);

        IEnumerable<ProductViewModel> GetAll();

        ProductViewModel GetById(int ProductId);
    }

    public class ProductService : IProductService
    {
        private readonly IMapper mapper;
        private readonly IProductRepository productRepository;

        public ProductService(
            IProductRepository productRepository,
            IMapper mapper
            )
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
        }

        public (bool, string, int) Create(ProductViewModel model)
        {
            try
            {
                //var category = model.ConvertToModel();
                var product = mapper.Map<ProductViewModel, Product>(model);
                return productRepository.Create(product);
            }
            catch (Exception ex)
            {
                return (false, ex.Message, 0);
            }
        }

        public IEnumerable<ProductViewModel> GetAll()
        {
            var data = productRepository.GetAll().ToList();
            var list = mapper.Map<List<Product>, List<ProductViewModel>>(data);
            return list;
        }

        public (bool, string, int) Edit(ProductViewModel model)
        {
            var product = mapper.Map<ProductViewModel, Product>(model);
            return productRepository.Update(product);
        }

        public ProductViewModel GetById(int ProductId)
        {
            var data = productRepository.GetById(ProductId);
            var returndata = mapper.Map<Product, ProductViewModel>(data);
            return returndata;
        }
    }
}
