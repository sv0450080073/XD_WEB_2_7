using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XD_WEB.Model.Models;
using XD_WEB.Service;
using XD_WEB.WEB1.Infrastructure.Core;
using XD_WEB.WEB1.Models;

namespace XD_WEB.WEB1.Controllers
{
    public class ProductController : Controller
    {
        IProductService _productService;
        IProductCategoryService _productCategoryService;
        public ProductController(IProductService productService, IProductCategoryService productCategoryService)
        {

            this._productService = productService;
            this._productCategoryService = productCategoryService;


             
        }


        // GET: Product
        public ActionResult Detail(int id)
        {
          


            return View();
        }
        public ActionResult Category(int id, int page=1)
        {
            int pageSize = 1;
            int totalRow = 0;
            var productModel = _productService.GetListProductByCategoryIdPaging(id, page, pageSize, out totalRow);
            var productViewModel = Mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(productModel);
            int totalpage = (int)Math.Ceiling( (double)totalRow/pageSize);

            var category = _productCategoryService.GetById(id);
            ViewBag.Category = Mapper.Map<ProductCategory, ProductCategoryViewModel>(category);
            var paginationSet = new PaginationSet<ProductViewModel>()
            {
                Items = productViewModel,
                MaxPage = 5,
                Page = page,
                TotalCount = totalRow,
                TotalPages = totalpage
           

            };



            return View(paginationSet);
        }
    }
}