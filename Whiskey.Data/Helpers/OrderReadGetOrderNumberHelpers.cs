using Microsoft.EntityFrameworkCore;
using Whiskey.Data.DatabaseContext;
using Whiskey.Domain.Entities;

namespace Whiskey.Data.Helpers
{
    internal static class OrderReadGetOrderNumberHelpers
    {

        public static readonly Func<ApplicationDbContext, string, Order> GetOrderNumber =
            EF
            .CompileQuery((ApplicationDbContext db, string orderNumber) => db.Orders
            .AsNoTracking()
            .Single(o => o.OrderNumber == orderNumber));
    }
}