using Observer_Pattern.Observable;

namespace Observer_Pattern.Observer
{
    public class MessageAlertObserver: INotificationObserver
    {
        IObservable _observable;
        string name;

        public MessageAlertObserver(string name, IObservable observable)
        {
            this.name = name;
            _observable = observable;
        }

        public void UpdateData()
        {
            Console.WriteLine($"Message sent to: {name}, count: {_observable.GetStockCount()}");
        }
    }
}
