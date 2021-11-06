public class InterfaceSegregation
{
    public interface MediaFetcher
    {
        public String getLink();
    }
    public interface GifFetcher:MediaFetcher
    {
        public String getLink();
    }
    public interface VideoFetcher:MediaFetcher
    {
        public String getLink();
    }
    public interface VideoFetcher:MediaFetcher
    {
        public String getLink();
    }
}