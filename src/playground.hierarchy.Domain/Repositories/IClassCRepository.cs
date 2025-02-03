using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace playground.hierarchy.Repositories;
public interface IClassCRepository : IRepository<ClassC, Guid>
{
}
