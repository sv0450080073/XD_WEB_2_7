using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
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
        public ActionResult Detail(long mid)
        {


            var productModel = _productService.GetById((int)(mid));
            var viewModel = Mapper.Map<Product, ProductViewModel>(productModel);
            var relatedProduct = _productService.GetReatedProducts((int)(mid), 6);
            ViewBag.RelatedProducts = Mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(relatedProduct);

            List<string> listImages = new JavaScriptSerializer().Deserialize<List<string>>(viewModel.MoreImages);
            ViewBag.MoreImages = listImages;

            return View(viewModel); 
        }
        //phân trang
        public ActionResult Category(int id, int page=1,string sort=" ")
        {
            int pageSize = 20;
            int totalRow = 0;
            var productModel = _productService.GetListProductByCategoryIdPaging(id, page, pageSize,sort, out totalRow);
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

        //Search
        public ActionResult Search(string keyWord, int page = 1, string sort = " ")
        {
            int pageSize = 20;
            int totalRow = 0;
            var productModel = _productService.Search(keyWord, page, pageSize, sort, out totalRow);
            var productViewModel = Mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(productModel);
            int totalpage = (int)Math.Ceiling((double)totalRow / pageSize);

            
            ViewBag.Keyword =keyWord;
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



        public JsonResult  GetListProductByName(string keyword)
        {

           var model= _productService.GetListProductByName(keyword);
           
            return Json(new
            {
                data = model
            }, JsonRequestBehavior.AllowGet);
        }


    }
}