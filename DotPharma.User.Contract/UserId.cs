namespace DotPharma.User.Contracts;

public readonly struct UserId
{
    private readonly Guid _id;

    public UserId(Guid id)
    {
        _id = id;
    }
}


