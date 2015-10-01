namespace ExtractArtists
{
    using System;
    using System.Collections.Generic;
    using System.Xml;
    class StartProgram
    {
        static void Main()
        {
            XmlDocument document = new XmlDocument();
            document.Load("../../catalog.xml");

            XmlNodeList artists = document.GetElementsByTagName("artist");

            var artistsAndSong = new Dictionary<string, int>();

             foreach (XmlNode artistNode in artists)
            {
                var artist = artistNode.InnerText;

                if (artistsAndSong.ContainsKey(artist))
                {
                    artistsAndSong[artist]++;
                }
                else
                {
                    artistsAndSong.Add(artist, 1);
                }
            }

            foreach (var entry in artistsAndSong)
            {
                Console.WriteLine("Artist: {0} has {1} album(s).", entry.Key, entry.Value);
            }
        }
    }
}