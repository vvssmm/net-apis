namespace NET.Apis.Domain.Pos
{
    public interface IPosClient
    {
        Task ReceiveMessage(string message);
    }
}
