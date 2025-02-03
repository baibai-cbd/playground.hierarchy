using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace playground.hierarchy.Dtos;
public class ClassADto : EntityDto<Guid>
{
    public string Name { get; set; }

    public List<ClassBDto> Bs { get; set; }
}

public class ClassAGetListDto : IPagedResultRequest
{
    public int SkipCount { get; set; }
    public int MaxResultCount { get; set; }
}

public class CreateUpdateClassADto
{
    public string Name { get; set; }

    public List<CreateUpdateClassBDto> Bs { get; set; }
}
