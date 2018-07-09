using Microsoft.VisualStudio.TestTools.UnitTesting;
using XD_WEB.Data.Infrastructure;
using XD_WEB.Data.Repositories;
using XD_WEB.Model.Models;

namespace XD_WEB.UnitTest.RepositoryTest
{
    [TestClass]
    public class PostCategoryRepositoryTest
    {
        IDbFactory dbFactory;
        IPostCategoryRepository objRepository;
        IUnitOfWork unitOfWork;

        [TestInitialize]
        public void Initialize()
        {
            dbFactory = new DbFactory();
            objRepository = new PostCategoryRepository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }
        [TestMethod]
        public void PostCategory_Repository_Create()
        {
            PostCategory category = new PostCategory();
            category.Name = "Test category";
            category.Alias = "Test-category";
            category.Status = true;
            var result= objRepository.Add(category);
            unitOfWork.Commit();


            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ID);
         
        }


     }
}