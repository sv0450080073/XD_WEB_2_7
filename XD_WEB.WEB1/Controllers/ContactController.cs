 using AutoMapper;
using BotDetect.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using XD_WEB.Common;
using XD_WEB.Model.Models;
using XD_WEB.Service;
using XD_WEB.Web.Infrastructure.Extensions;
using XD_WEB.WEB1.Models;

namespace XD_WEB.WEB1.Controllers
{
    public class ContactController : Controller
    {
        IContactDetailService _contactDetailService;
        IFeedbackService _feedbackService;
        public ContactController(IContactDetailService contactDetailService, IFeedbackService feedbackService)
        {
            this._contactDetailService = contactDetailService;
            this._feedbackService = feedbackService;
        }


        // GET: Contact
        public ActionResult Index()
        {
           
            FeedbackViewModel viewModel = new FeedbackViewModel();
            viewModel.ContactDetail = GetDetail();
            return View(viewModel);
        }

        [HttpPost]
        [CaptchaValidation("CaptchaCode", "contactCaptcha", "Mã xác nhận không đúng!")]
        public ActionResult SendFeedback(FeedbackViewModel feedbackViewModel)
        {
            if (ModelState.IsValid)
            {
                Feedback newfeedback = new Feedback();
                newfeedback.UpdateFeedback(feedbackViewModel);
                _feedbackService.Create(newfeedback);
                _feedbackService.Save();

                ViewData["SuccessMsg"] = "Gửi phản hồi thành công";
               

                string content = System.IO.File.ReadAllText(Server.MapPath("/Assets/client/template/contact_template.html"));
                content = content.Replace("{{Name}}", feedbackViewModel.Name);
                content = content.Replace("{{Email}}", feedbackViewModel.Email);
                content = content.Replace("{{Message}}", feedbackViewModel.Message);

                var adminEmail = ConfigHelper.GetByKey("AdminEmail"); 
                MailHelper.SendMail(adminEmail, "Thông tin liên hệ từ website", content);



                feedbackViewModel.Name = "";

                feedbackViewModel.Email = "";
                feedbackViewModel.Message = ""; 
            }

            feedbackViewModel.ContactDetail = GetDetail();
            
            return View("Index", feedbackViewModel);
             
        }
        private ContactDetailViewModel GetDetail ()
        {
            var model = _contactDetailService.GetDefaultContact();
            var contactViewModel = Mapper.Map<ContactDetail, ContactDetailViewModel>(model);
            return contactViewModel;
        }

    }
}