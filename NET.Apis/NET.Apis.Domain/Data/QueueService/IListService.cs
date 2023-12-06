namespace NET.Apis.Domain.Data.QueueService
{
    public interface IListService
    {
        void AddItem(string value);
        int RemoveItem(string value);
        IList<string> GetItems();
    }
}
