namespace DotPharma.Catalog.Contracts;

public readonly struct GroupId
{
    private readonly int _id;

    public GroupId(int id)
    {
        if (id == 0)
            throw new ArgumentException("Id cannot be empty or zero");
        
        _id = id;
    }
    
    public static implicit operator GroupId(int id) => new GroupId(id);
    public static implicit operator int(GroupId groupId) => groupId._id;
    public override string ToString() => _id.ToString();
}

public readonly struct SubGroupId
{
    private readonly int _id;

    public SubGroupId(int id)
    {
        if (id == 0)
            throw new ArgumentException("Id cannot be empty or zero");

        _id = id;
    }

    public static implicit operator SubGroupId(int id) => new SubGroupId(id);
    public static implicit operator int(SubGroupId groupId) => groupId._id;
    public override string ToString() => _id.ToString();
}