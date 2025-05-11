

using patron_observer.Domain;
using patron_observer.Publisher;
using patron_observer.Subscriber;
using patron_observer.Classifier;

namespace patron_observer
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Inicializar grupos de interés
            var groups = new List<ScienceGroup>
            {
                new ScienceGroup(ScienceCategory.Astronomy),
                new ScienceGroup(ScienceCategory.Physics),
                new ScienceGroup(ScienceCategory.Biology)
            };

            // Inicializar miembros del club con intereses (cada uno se suscribe automáticamente al agregar intereses)
            var members = new List<ScienceFan>
            {
                new ScienceFan("Wilson Vargas", new List<ScienceCategory>()),
                new ScienceFan("María López", new List<ScienceCategory>())
            };

            // Asignar intereses usando el método que también suscribe
            members[0].AddInterest(ScienceCategory.Astronomy, groups);
            members[0].AddInterest(ScienceCategory.Physics, groups);

            members[1].AddInterest(ScienceCategory.Biology, groups);

            // Clasificador de videos para el grupo
            var publisher = new VideoPublisher(groups);

            // Videos obtenidos
            var videos = new List<Video>
            {
                new Video("Cosmos Científico", "Explosiones de supernovas", ScienceCategory.Astronomy),
                new Video("Física para Todos", "La paradoja de los gemelos", ScienceCategory.Physics),
                new Video("BioCurioso", "Mutaciones genéticas raras", ScienceCategory.Biology)
            };

            // Notificar a los grupos los videos
            foreach (var video in videos)
            {
                Console.WriteLine($"[Programa] Procesando video: '{video.Title}' (Categoría: {video.Category})");

                // Determinar el grupo al que pertenece el video
                var group = publisher.GetGroupFor(video);
                if (group != null)
                {
                    Console.WriteLine($"[Programa] Notificando al grupo {group.Category}");
                    group.Notify(video);
                }
                else
                {
                    Console.WriteLine($"[Programa] No hay grupo para la categoría {video.Category}. Video ignorado.");
                }
            }

        }
    }
}