namespace DesignPatterns.Creational.ObjectPool
{
    internal class ItemPool
    {
        private readonly IReadOnlyCollection<Item> _items;
        public ItemPool(int capacity)
        {
            var items = new List<Item>(capacity);
            for (int i = 0; i < capacity; i++)
            {
                items.Add(new Item());
            }
            _items = items.AsReadOnly();
        }

        public Item? Acquire()
        {
            foreach (var item in _items)
            {
                if (!item.IsVisible)
                {
                    item.IsVisible = true;
                    return item;
                }
            }
            return null;
        }

    }
}
