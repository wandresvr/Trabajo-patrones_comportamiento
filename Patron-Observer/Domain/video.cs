namespace patron_observer.Domain
{
   public class Video
    {
        public string ChannelName { get; }
        public string Title { get; }
        public ScienceCategory Category { get; }

        public Video(string channelName, string title, ScienceCategory category)
        {
            ChannelName = channelName;
            Title = title;
            Category = category;
        }
    }
}