using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XD_WEB.Data.Infrastructure;
using XD_WEB.Data.Repositories;
using XD_WEB.Model.Models;

namespace XD_WEB.Service
{

    public interface IContactDetailService
    {
        ContactDetail GetDefaultContact();
    }


    public class ContactDetailService : IContactDetailService
    {

        IContactDetailRepository _contactDetailRepository;
        IUnitOfWork _unitOfWork;
        public ContactDetailService(IContactDetailRepository contactDetailRepository, IUnitOfWork unitOfWork)
        {
            this._contactDetailRepository = contactDetailRepository;
            this._unitOfWork = unitOfWork;
        }
        public ContactDetail GetDefaultContact()
        {
            return _contactDetailRepository.GetSingleByCondition(x => x.Status);
        }
    }
}
