using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace playground.hierarchy.Dtos;
public class ClassCDto : EntityDto<Guid>
{
    public Guid ParentId { get; set; }
    public string Description { get; set; }
}

public class CreateUpdateClassCDto
{
    public Guid Id { get; set; }
    public Guid ParentId { get; set; }
    public string Description { get; set; }
}
