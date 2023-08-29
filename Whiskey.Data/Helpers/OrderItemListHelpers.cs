using Microsoft.EntityFrameworkCore;
using Whiskey.Data.DatabaseContext;
using Whiskey.Domain.Entities;

namespace Whiskey.Data.Helpers
{
    internal static class OrderItemListHelpers
    {

        public static readonly Func<ApplicationDbContext, IList<OrderItem>> CompiledQuery =
          (Func<ApplicationDbContext, IList<OrderItem>>)EF.CompileQuery(
                  (ApplicationDbContext orderItem) =>
                  orderItem.OrderItems
                  .AsNoTracking()
                  .Select(db => new List<OrderItem>()
                  .Take(20)));
    }
}