using CER3.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CER3.Models.Observer
{
    internal class Observer : IDiagramPattern
    {
        public string Name { get; }
        public string Description { get; }
        public List<Subscriber> Subscribers { get; } = new List<Subscriber>();

        public Observer(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public override string ToString()
        {
            return Name + " " + Description;
        }
         public bool AddSubscriber(Subscriber subscriber)
        {
            try
            {
                Subscribers.Add(subscriber);
                Console.WriteLine("Adding " + subscriber.ToString());
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool RemoveSubscriber(Subscriber subscriber)
        {
            try
            {
                Subscribers.Remove(subscriber);
                Console.WriteLine("Removing " + subscriber.ToString());
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool NotifySubscriber()
        {
            try
            {
                foreach (Subscriber subscriber in Subscribers)
                {
                    Console.WriteLine("Notify " + subscriber.ToString());
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static void Test(ConsoleView console)
        {
            var testObserver = new Observer("Observer", "this is a Test");
            console.ConsoleWrite(testObserver.ToString());
            var subscriber1 = new Subscriber("Sub1");
            var subscriber2 = new Subscriber("Sub2");
            var subscriber3 = new Subscriber("Sub3");
            testObserver.AddSubscriber(subscriber1);
            testObserver.AddSubscriber(subscriber2);
            testObserver.AddSubscriber(subscriber3);
            testObserver.RemoveSubscriber(subscriber2);
            testObserver.NotifySubscriber();
        }
    }
}
