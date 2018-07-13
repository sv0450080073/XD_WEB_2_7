using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XD_WEB.Model.Models;
using XD_WEB.Service;
using XD_WEB.Web.Infrastructure.Core;
using XD_WEB.WEB1.Models;

namespace XD_WEB.WEB1.Api
{
    [RoutePrefix("api/productcategory")] // điều hướng 
    public class ProductCategoryController : ApiControllerBase
    {
        IProductCategoryService _productCategoryService;

        public ProductCategoryController(IErrorService errorService,IProductCategoryService productCategoryService)
            :base(errorService)
        {
            this._productCategoryService = productCategoryService;
        }

        [Route("getall")]
         public HttpResponseMessage GetAll(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
             {
                 var model = _productCategoryService.GetAll();
                 var responseData = Mapper.Map<IEnumerable<ProductCategory>, IEnumerable<ProductCategoryViewModel>>(model);
                 var response = request.CreateResponse(HttpStatusCode.OK, responseData);


                 return response;
             });

        }
    }
}
