namespace NET.Apis.Domain.Pos
{
    public interface IPosSignalRClient
    {
        Task ReceiveMessage(string user,string message);
    }
}
