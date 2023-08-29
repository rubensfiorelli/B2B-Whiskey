using Microsoft.EntityFrameworkCore;
using Whiskey.Data.DatabaseContext;
using Whiskey.Data.Helpers;
using Whiskey.Domain.Entities;
using Whiskey.Domain.Repository.Output;

namespace Whiskey.Data.Repositories.Output
{
    public sealed class CostumerReadRepository : ICostumerReadRepository
    {
        private readonly ApplicationDbContext _db;

        public CostumerReadRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<List<Costumer>> GetAllOrdersAsync()
        {
            try
            {
                using var db = _db;
                var customers = new List<Costumer>();

                return await Task.Run(() => customers);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public async Task<Costumer> GetIdAsync(Guid id)
        {
            try
            {
                using var db = _db;
                return await Task.Run(() => CostumerIdHelpers.CostumerById(db, id));

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Costumer>> GetLastNameAsync(string lastName)
        {
            try
            {
                IQueryable<Costumer> costumers = (IQueryable<Costumer>)_db.Costumers
                .Select(ln => ln.LastName.Normalize())
                .AsNoTracking();


                return await costumers.ToListAsync();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}

