using Observer_Pattern.Observable;
using Observer_Pattern.Observer;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var demoObservable_1 = new DemoObservable();
            var mobileObserver_1 = new MessageAlertObserver("name_1", demoObservable_1);
            var mobileObserver_2 = new MessageAlertObserver("name_2", demoObservable_1);
            var mobileObserver_3 = new EmailAlertObserver("email_1", demoObservable_1);

            demoObservable_1.AddData(mobileObserver_1);
            demoObservable_1.AddData(mobileObserver_2);
            demoObservable_1.AddData(mobileObserver_3);

            demoObservable_1.SetStockCount(10);
            demoObservable_1.SetStockCount(-10);
            demoObservable_1.SetStockCount(7);

            Console.ReadLine();
        }
    }
}