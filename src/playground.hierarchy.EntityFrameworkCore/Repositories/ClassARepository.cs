using Microsoft.EntityFrameworkCore;
using playground.hierarchy.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace playground.hierarchy.Repositories;
public class ClassARepository : EfCoreRepository<hierarchyDbContext, ClassA, Guid>, IClassARepository
{
    public ClassARepository(IDbContextProvider<hierarchyDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public override async Task<IQueryable<ClassA>> WithDetailsAsync()
    {
        return (await GetQueryableAsync()).IncludeDetails();
    }
}

public static class ClassAQueryableExtensions
{
    public static IQueryable<ClassA> IncludeDetails(this IQueryable<ClassA> queryable, bool include = true)
    {
        if (!include)
            return queryable;
        else
            return queryable
                    .Include(x => x.Bs)
                    .ThenInclude(y => y.Cs);
    }
}
