using Observer_Pattern.Observable;

namespace Observer_Pattern.Observer
{
    public class EmailAlertObserver: INotificationObserver
    {
        IObservable _observable;
        string emailId;

        public EmailAlertObserver(string emailId, IObservable observable)
        {
            this.emailId = emailId;
            _observable = observable;
        }

        public void UpdateData()
        {
            Console.WriteLine($"Email sent to: {emailId}, count: {_observable.GetStockCount()}");
        }
    }
}
