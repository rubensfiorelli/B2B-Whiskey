using Microsoft.EntityFrameworkCore;
using Whiskey.Data.DatabaseContext;
using Whiskey.Domain.Entities;

namespace Whiskey.Data.Helpers
{
    internal static class CostumerIdHelpers
    {

        public static readonly Func<ApplicationDbContext, Guid, Costumer> CostumerById =
                               EF.CompileQuery((ApplicationDbContext db, Guid id) => db.Costumers
                               .AsNoTracking()
                               .Single(l => l.Id == id));
    }
}