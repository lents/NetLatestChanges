class User(string username)
{
    public string Username { get; } = username;
}

class OrderController(IUserRepository repository)
{
    public (Guid, decimal) GetTotalFor(Guid orderId)
    {
        return (orderId, repository.Sum(orderId));
    }
}

interface IUserRepository
{
    public decimal Sum(Guid orderId) => 0m;
}
