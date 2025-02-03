using playground.hierarchy.Dtos;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace playground.hierarchy;
public class ClassAAppService : CrudAppService<ClassA, ClassADto, Guid, ClassAGetListDto, CreateUpdateClassADto>
{
    public ClassAAppService(IRepository<ClassA, Guid> repository) : base(repository)
    {
    }

    public override Task<ClassADto> CreateAsync(CreateUpdateClassADto input)
    {
        SetupChildIds(input);

        return base.CreateAsync(input);
    }

    public override Task<ClassADto> UpdateAsync(Guid id, CreateUpdateClassADto input)
    {
        SetupChildIds(input);

        return base.UpdateAsync(id, input);
    }

    private void SetupChildIds(CreateUpdateClassADto input)
    {
        foreach (var item in input.Bs)
        {
            if (item.Id == Guid.Empty)
                item.Id = GuidGenerator.Create();

            foreach (var inner in item.Cs)
            {
                if (inner.Id == Guid.Empty)
                    inner.Id = GuidGenerator.Create();
            }
        }
    }
}
