using System.Threading.Tasks;

namespace MyProject.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        //IKullaniciRepository Products { get; }

        //ICategoryRepository categories { get; }

        Task CommitAsync();

        void Commit();
    }

}
