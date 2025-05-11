
using patron_observer.Domain;

namespace patron_observer.Interfaces
{

public interface ISubject
    {
        void Register(IObserver observer);
        void Unregister(IObserver observer);
        void Notify(Video video);
    }
}