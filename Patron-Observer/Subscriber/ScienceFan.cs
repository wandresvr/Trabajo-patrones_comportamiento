
using patron_observer.Interfaces;
using patron_observer.Domain;
using patron_observer.Publisher;
using System.Collections.Generic;

namespace patron_observer.Subscriber
{
   public class ScienceFan : IObserver
    {
        public string Name { get; }
        public List<ScienceCategory> Interests { get; }

        public ScienceFan(string name, IEnumerable<ScienceCategory> interests)
        {
            Name = name;
            Interests = new List<ScienceCategory>(interests);
            Console.WriteLine($"[Usuario] {Name} creado con intereses: {string.Join(", ", Interests)}");
        }

        // Método para agregar un nuevo interés y suscribirse al grupo correspondiente
        public void AddInterest(ScienceCategory newInterest, IEnumerable<ScienceGroup> availableGroups)
        {
            if (!Interests.Contains(newInterest))
            {
                Interests.Add(newInterest);
                Console.WriteLine($"[Usuario] {Name} ha añadido un nuevo interés: {newInterest}");

                // Registrar al miembro en el grupo correspondiente
                var group = availableGroups.FirstOrDefault(g => g.Category == newInterest);
                group?.Register(this); // Suscribir al grupo
            }
        }

        // Método para eliminar un interés y desuscribirse del grupo correspondiente
        public void RemoveInterest(ScienceCategory category, IEnumerable<ScienceGroup> availableGroups)
        {
            if (Interests.Remove(category))
            {
                var group = availableGroups.FirstOrDefault(g => g.Category == category);
                group?.Unregister(this); // Desuscribir del grupo
                Console.WriteLine($"[Usuario] {Name} ha eliminado el interés: {category}");
            }
        }

        // Método para recibir notificaciones de los videos
        public void Update(Video video)
        {
            Console.WriteLine($"  -> [Notificación] {Name} recibe: '{video.Title}' de {video.ChannelName} [{video.Category}]");
        }

        // Método que devuelve los intereses del usuario (los grupos a los que está suscrito)
        public void PrintInterests()
        {
            Console.WriteLine($"Miembro: {Name}");
            Console.WriteLine("  Grupos de interés:");
            foreach (var interest in Interests)
            {
                Console.WriteLine($"    - {interest}");
            }
        }
    }
}