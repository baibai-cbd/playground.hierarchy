using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace playground.hierarchy.Dtos;
public class ClassBDto : EntityDto<Guid>
{
    public Guid ParentId { get; set; }
    public int Property1 { get; set; }

    public List<ClassCDto> Cs { get; set; } = [];
}

public class CreateUpdateClassBDto
{
    public Guid Id { get; set; }
    public Guid ParentId { get; set; }
    public int Property1 { get; set; }

    public List<CreateUpdateClassCDto> Cs { get; set; }
}
