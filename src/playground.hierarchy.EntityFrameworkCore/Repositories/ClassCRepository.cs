using playground.hierarchy.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace playground.hierarchy.Repositories;
public class ClassCRepository : EfCoreRepository<hierarchyDbContext, ClassC, Guid>, IClassCRepository
{
    public ClassCRepository(IDbContextProvider<hierarchyDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
