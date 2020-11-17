namespace Domain
{
    public interface IIdentity<TId>
    {
        TId Id { get; }
    }
}
