using MyProject.Core.Services;
using MyProject.Entities.Tables;
using System.Threading.Tasks;

namespace MyProject.BusinessLayer.Interfaces
{
    public interface IKullaniciService : IService<Kullanici>
    {
        Task<Kullanici> GetWithCategoryByIdAsync(int productId);

        //  bool ControlInnerBarcode(Product product);
    }
}
