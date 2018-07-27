using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XD_WEB.Model.Models;
using XD_WEB.Service;
using XD_WEB.WEB1.Models;

namespace XD_WEB.WEB1.Controllers
{
    public class HomeController : Controller
    {
         //trong start up đã cấu hình service rồi 
        IProductCategoryService _productCategoryService;
        IProductService _productService;
        ICommonService _commonService;


        public HomeController(IProductCategoryService productCategoryService,
            IProductService productService,ICommonService commonService)
        {
            _productCategoryService = productCategoryService;
            _commonService = commonService;
            _productService = productService;  
         }


        // GET: Home
        public ActionResult Index()
        {
            var slideModel = _commonService.GetSlides();
            var slideView = Mapper.Map<IEnumerable< Slide>, IEnumerable< SlideViewModel>>(slideModel);
            var homeViewModel = new HomeViewModel();
            homeViewModel.Slides = slideView;


            var lastestProductModel = _productService.GetLastest(3);
            var topSaleProductModel = _productService.GetHotProduct(3);
            var lastestProductViewModel = Mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(lastestProductModel);
            var topSaleProducViewtModel = Mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(topSaleProductModel);
            homeViewModel.LastestProducts = lastestProductViewModel;
            homeViewModel.TopSaleProducts = topSaleProducViewtModel;

            return View(homeViewModel);
        }

        //footer
        [ChildActionOnly]
        [OutputCache(Duration = 3600)]
        public ActionResult Footer()
        {
            var footerModel = _commonService.GetFooter();
            var footerViewModel = Mapper.Map<Footer, FooterViewModel>(footerModel);

            ViewBag.Time = DateTime.Now.ToString("T");
            return PartialView(footerViewModel);
        }

         
        //Header
        [ChildActionOnly]
        [OutputCache(Duration = 3600)]
        public ActionResult Header()
        {
            return PartialView();
        }
        //Category
        [ChildActionOnly]
        public ActionResult Category()
        {
            var model = _productCategoryService.GetAll();
            var listProductCategoryViewModel = Mapper.Map<IEnumerable<ProductCategory>, IEnumerable<ProductCategoryViewModel>>(model);

            
            return PartialView(listProductCategoryViewModel);
        }
    }
}