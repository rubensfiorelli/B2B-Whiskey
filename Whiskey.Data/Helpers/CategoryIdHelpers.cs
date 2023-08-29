using Microsoft.EntityFrameworkCore;
using Whiskey.Data.DatabaseContext;
using Whiskey.Domain.Entities;

internal static class CategoryIdHelpers
{

    public static readonly Func<ApplicationDbContext, Guid, Category> CategoryById =
       EF.CompileQuery((ApplicationDbContext db, Guid id) => db.Categories
       .AsNoTracking()
       .Single(l => l.Id == id));

}