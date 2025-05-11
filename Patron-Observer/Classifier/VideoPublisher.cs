using patron_observer.Domain;
using patron_observer.Publisher;

namespace patron_observer.Classifier
{
    public class VideoPublisher
    {
        private readonly Dictionary<ScienceCategory, ScienceGroup> _groups;

        public VideoPublisher(IEnumerable<ScienceGroup> groups)
        {
            _groups = new Dictionary<ScienceCategory, ScienceGroup>();
            foreach (var group in groups)
            {
                _groups[group.Category] = group;
            }
        }

        public ScienceGroup GetGroupFor(Video video)
        {
            if (_groups.TryGetValue(video.Category, out var group))
            {
                return group;
            }
            return null;
        }
    }
}