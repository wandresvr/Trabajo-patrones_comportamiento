using patron_observer.Interfaces;
using patron_observer.Domain;

namespace patron_observer.Publisher
{
    

    public class ScienceGroup : ISubject
    {
        private readonly List<IObserver> _members = new List<IObserver>();
        public ScienceCategory Category { get; }

        public ScienceGroup(ScienceCategory category)
        {
            Category = category;
            Console.WriteLine($"[Sistema] Grupo de interés creado para: {Category}");
        }

        public void Register(IObserver observer)
        {
            _members.Add(observer);
            Console.WriteLine($"[Acción] Miembro suscrito al grupo {Category}");
        }

        public void Unregister(IObserver observer)
        {
            _members.Remove(observer);
            Console.WriteLine($"[Acción] Miembro dado de baja del grupo {Category}");
        }

        public void Notify(Video video)
        {
            Console.WriteLine($"[Grupo {Category}] Notificando miembros sobre: '{video.Title}' de {video.ChannelName}");
            foreach (var member in _members)
            {
                member.Update(video);
            }
        }
    }

 }
