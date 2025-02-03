using Microsoft.EntityFrameworkCore;
using playground.hierarchy.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace playground.hierarchy.Repositories;
public class ClassBRepository : EfCoreRepository<hierarchyDbContext, ClassB, Guid>, IClassBRepository
{
    public ClassBRepository(IDbContextProvider<hierarchyDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}

public static class ClassBQueryableExtensions
{
    public static IQueryable<ClassB> IncludeDetails(this IQueryable<ClassB> queryable, bool include = true)
    {
        if (!include)
            return queryable;
        else
            return queryable
                    .Include(x => x.Cs);
    }
}