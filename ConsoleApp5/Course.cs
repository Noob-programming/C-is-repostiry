using System.Collections.Generic;

namespace ConsoleApp5
{
    public class Course : ISubject
    {
        private readonly string _name;
        private string _availbil;

        private readonly List<IObserver> _observers;

        public Course(string name)
        {
            _name = name;
            _observers = new List<IObserver>();
        }

        public void notif()
        {
            foreach (var item in _observers) item.Updata(_availbil);
        }

        public void sub(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void unsub(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void setAvaility(bool ave)
        {
            _availbil = $"{_name}{(ave ? " ave" : " not ave")}";
            notif();
        }
    }
}