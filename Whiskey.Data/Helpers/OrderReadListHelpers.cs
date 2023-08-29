using Microsoft.EntityFrameworkCore;
using Whiskey.Data.DatabaseContext;
using Whiskey.Domain.Entities;

namespace Whiskey.Data.Helpers
{
    internal static class OrderReadListHelpers
    {

        public static readonly Func<ApplicationDbContext, IList<Order>> CompiledQuery =
           (Func<ApplicationDbContext, IList<Order>>)EF.CompileQuery(
                   (ApplicationDbContext order) =>
                        order.Orders
                            .AsNoTracking()
                                .Select(db => new List<Order>().Take(20)));
    }
}