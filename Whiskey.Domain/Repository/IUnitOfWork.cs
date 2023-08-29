namespace Whiskey.Domain.Repository
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
        Task Rollback();

    }
}
