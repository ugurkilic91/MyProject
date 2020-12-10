using MyProject.BusinessLayer.BaseServices;
using MyProject.BusinessLayer.Interfaces;
using MyProject.Core.Repositories;
using MyProject.Core.UnitOfWorks;
using MyProject.Entities.Tables;
using System;
using System.Threading.Tasks;

namespace MyProject.BusinessLayer.Services
{
    public class KullaniciService : Service<Kullanici>, IKullaniciService
    {
        public KullaniciService(IUnitOfWork unitOfWork, IRepository<Kullanici> repository) : base(unitOfWork, repository)
        {
        }

        public Task<Kullanici> GetWithCategoryByIdAsync(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
