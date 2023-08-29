using Microsoft.EntityFrameworkCore;
using Whiskey.Data.DatabaseContext;
using Whiskey.Domain.Entities;

namespace Whiskey.Data.Helpers
{
    internal static class ProductReadListHelpers
    {

        public static readonly Func<ApplicationDbContext, IList<Product>> CompiledQuery =
           (Func<ApplicationDbContext, IList<Product>>)EF.CompileQuery(
                   (ApplicationDbContext product) =>
                        product.Products
                            .AsNoTracking()
                                .Select(db => new List<Product>().Take(20)));
    }
}