using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace playground.hierarchy;
public class ClassA : AggregateRoot<Guid>
{
    public ClassA(Guid id) : base(id) { }

    public ClassA()
    {
    }

    public string Name { get; set; }

    public List<ClassB> Bs { get; set; } = [];
}

public class ClassB : Entity<Guid>
{
    public ClassB(Guid id) : base(id) { }

    public ClassB()
    {
    }

    public Guid ParentId { get; set; }
    public int Property1 { get; set; }

    public List<ClassC> Cs { get; set; } = [];
}

public class ClassC : Entity<Guid>
{
    public ClassC(Guid id) : base(id) { }

    public ClassC()
    {
    }

    public Guid ParentId { get; set; }
    public string Description { get; set; }
}
