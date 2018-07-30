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

    public interface IFeedbackService
    {

        Feedback Create(Feedback feedback);
        void Save();

    }


    public class FeedbackService : IFeedbackService
    {

        IFeedbackRepository _feedbackRepository;
        IUnitOfWork _unitOfWork;

        public FeedbackService(IFeedbackRepository feedbackRepository,IUnitOfWork unitOfWork)
        {
            this._feedbackRepository = feedbackRepository;
            this._unitOfWork = unitOfWork;


        }
        public Feedback Create(Feedback feedback)
        {
            return _feedbackRepository.Add(feedback);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}
