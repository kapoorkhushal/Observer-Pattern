using Observer_Pattern.Observer;

namespace Observer_Pattern.Observable
{
    public class DemoObservable: IObservable
    {
        private IList<INotificationObserver> myList;
        private int stockCount = 0;
        public DemoObservable()
        {
            myList = new List<INotificationObserver>();
        }
        public void AddData(INotificationObserver value)
        {
            myList.Add(value);
            Console.WriteLine("New Observer added into Demo Observable 1");
        }

        public void RemoveData(INotificationObserver value)
        {
            myList.Remove(value);
            Console.WriteLine("An Observer removed from Demo Observable 1");
        }

        public void SetStockCount(int newCount)
        {
            var oldStockCount = stockCount;
            stockCount += newCount;

            if (oldStockCount <= 0)
            {
                this.Notify();
            }
        }

        public int GetStockCount()
        {
            return this.stockCount;
        }

        private void Notify()
        {
            foreach (var observer in myList)
            {
                observer.UpdateData();
            }
        }
    }
}
