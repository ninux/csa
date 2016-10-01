using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uebung02_events
{
    public delegate void MyEventHandler(object sender, MyEventArgs e);

    public class MyEventArgs : EventArgs
    {
        public string EventData;

        public MyEventArgs(string initial)
        {
            EventData = initial;
        }
    }
    
    public class EventProducer
    {
        public event MyEventHandler MyEvent;
        public event MyEventHandler Person;

        public void OnEvent(string data)
        {
            if (MyEvent != null)
            {
                MyEvent(this, new MyEventArgs(data));
            }
        }

        public void OnNewPerson(string data)
        {
            if (Person != null)
            {
                Person(this, new MyEventArgs(data));
            }
        }

    }

    public class EventConsumer
    {
        public EventConsumer(EventProducer ep)
        {
            ep.MyEvent += PrintMessage;
        }

        public void PrintMessage(object sender, MyEventArgs e)
        {
            Console.WriteLine(e.EventData);
        }
        
    }

    public class Ninux
    {
        public Ninux(EventProducer ep)
        {
            ep.MyEvent += HiNinux;
        }

        public void HiNinux(object sender, MyEventArgs e)
        {
            Console.WriteLine("new person \"" + e.EventData + "\" arrived");
        }
    }

    class Program
    {
        public Program()
        {
            EventProducer producer = new EventProducer();
            EventConsumer consumer1 = new EventConsumer(producer);
            EventConsumer consumer2 = new EventConsumer(producer);
            Ninux n = new Ninux(producer);

            producer.OnEvent("Event fired");
            producer.OnNewPerson("Jan Vonmoos");

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Program prg = new Program();
            Console.Read();
        }
    }
}