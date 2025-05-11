using patron_observer.Domain;

namespace patron_observer.Interfaces
{
    public interface IObserver
    {
        void Update(Video video);
    }

}