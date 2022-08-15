using System.Net;
namespace MyCodeLibrary
{
    public class Scrape
    {
        public string ScrapeWebpage(string url)
        {
            return Getweebpage(url);

        } 
        public string ScrapeWebpage(string url, string filepath)
        {

            string reply = Getweebpage(url);
            File.WriteAllText(filepath, reply);
            return reply;

        }
        private string Getweebpage(string url)
        {
            WebClient client = new WebClient();
            return client.DownloadString(url);
        }
    }
}