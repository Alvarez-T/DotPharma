using Dotfy.Location.Contracts;

namespace DotPharma.Customer.Contracts;

public readonly record struct CustomerId
{
    private readonly int _id;

    public CustomerId()
    {
        
    }

    public CustomerId(int id)
    {
        if (id <= 0)
            throw new ArgumentException("Id cannot be less or equal zero");

        _id = id;
    }

    public static implicit operator CustomerId(int id) => new CustomerId(id);
    public static implicit operator int(CustomerId customerId) => customerId._id;
    public override string ToString() => _id.ToString();
}