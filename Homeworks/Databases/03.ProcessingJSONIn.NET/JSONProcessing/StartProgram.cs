namespace JSONProcessing
{
    using Newtonsoft.Json;
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Xml;
    using Newtonsoft.Json.Linq;

    class StartProgram
    {
        private const string RssLink = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            string content = DownLoadRss(RssLink);
            string json = ConvertXmlToJson(content);

            var titles = GetVideoTitles(json);
            PrintTitles(titles);

            var videos = GetVideos(json);
            GenerateHtml(videos);
        }

        private static string DownLoadRss(string url)
        {
            var webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            var data = webClient.DownloadData(url);
            var content = Encoding.UTF8.GetString(data);

            return content;
        }

        private static string ConvertXmlToJson(string xml)
        {
            var doc = new XmlDocument();
            doc.LoadXml(xml);

            var json = JsonConvert.SerializeObject(doc, Newtonsoft.Json.Formatting.Indented);

            return json;
        }

        private static IEnumerable<JToken> GetVideoTitles(string json)
        {
            var jsonObject = JObject.Parse(json);

            return jsonObject["feed"]["entry"]
                   .Select(entry => entry["title"]);
        }

        private static void PrintTitles(IEnumerable<JToken> titles)
        {
            var counter = 1;
            foreach (var title in titles)
            {
                Console.WriteLine(counter + ". " + title);
                counter++;
            }
        }

        private static IEnumerable<Video> GetVideos(string json)
        {
            var jsonObject = JObject.Parse(json);

            return jsonObject["feed"]["entry"]
                   .Select(entry => JsonConvert.DeserializeObject<Video>(entry.ToString()));
        }

        private static void GenerateHtml(IEnumerable<Video> videos)
        {
            var html = "<!DOCTYPE html><html><body>";

            foreach (var video in videos)
            {
                html += string.Format("<div style=\"float:left; width: 400px; height: 430px; padding:10px;" +
                                  "margin:5px; background-color:yellowgreen; border-radius:10px\">" +
                                  "<iframe width=\"400\" height=\"325\" " +
                                  "src=\"http://www.youtube.com/embed/{2}?autoplay=0\" " +
                                  "frameborder=\"0\" allowfullscreen></iframe>" +
                                  "<h3>{1}</h3><a href=\"{0}\"><button>" + 
                                  "<strong>Go to YouTube</strong></button></a></div>", 
                                  video.Link.Href, video.Title, video.Id);
            }

            html += ("</body></html>");

            File.WriteAllText("../../index.html", html);
        }
    }
}