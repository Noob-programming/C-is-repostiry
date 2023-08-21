namespace ConsoleApp5
{
    public interface ISubject
    {
        void notif();

        void sub(IObserver observer);

        void unsub(IObserver observer);
    }
}