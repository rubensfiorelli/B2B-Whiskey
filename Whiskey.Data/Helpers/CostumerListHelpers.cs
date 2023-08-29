using Microsoft.EntityFrameworkCore;
using Whiskey.Data.DatabaseContext;
using Whiskey.Domain.Entities;

namespace Whiskey.Data.Helpers
{
    internal static class CostumerListHelpers
    {

        public static readonly Func<ApplicationDbContext, IList<Costumer>> CompiledQuery =
           (Func<ApplicationDbContext, IList<Costumer>>)EF.CompileQuery(
                   (ApplicationDbContext customer) =>
                        customer.Costumers
                            .AsNoTracking()
                                .Select(db => new List<Costumer>().Take(20)));
    }
}