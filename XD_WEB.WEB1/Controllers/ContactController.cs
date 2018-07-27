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
    public class ContactController : Controller
    {
        IContactDetailService _contactDetailService;
        public ContactController(IContactDetailService contactDetailService)
        {
            this._contactDetailService = contactDetailService;
        }


        // GET: Contact
        public ActionResult Index()
        {
            var model = _contactDetailService.GetDefaultContact();
            var contactViewModel = Mapper.Map<ContactDetail, ContactDetailViewModel>(model);
                
            return View(contactViewModel);
        }
    }
}