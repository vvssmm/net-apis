namespace NET.Apis.Domain.Data.QueueService
{
    public class ListService : IListService
    {
        private readonly IList<string> _listItem = new List<string>();
        public void AddItem(string value)
        {
            _listItem.Add(value);
        }

        public IList<string> GetItems()
        {
            return _listItem;
        }

        public int RemoveItem(string value)
        {
            var index = _listItem.IndexOf(value);
            if (index != -1)
            {
                _listItem.RemoveAt(index);
            }
            return index;
        }
    }
}
