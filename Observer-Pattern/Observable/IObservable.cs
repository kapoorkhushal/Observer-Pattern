using Observer_Pattern.Observer;

namespace Observer_Pattern.Observable
{
    public interface IObservable
    {
        void AddData(INotificationObserver value);
        void RemoveData(INotificationObserver value);
        void SetStockCount(int newCount);
        int GetStockCount();
    }
}
