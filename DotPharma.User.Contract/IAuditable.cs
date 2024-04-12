namespace DotPharma.User.Contracts;

public interface IAuditable
{
    AuditInfo AuditInfo { get; }
}

public record AuditInfo(UserId PerformedBy, DateTime PerfomedIn);
