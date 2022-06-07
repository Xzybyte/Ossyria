using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace Ossyria.News
{
    internal class Parse
    {

        private List<Post> posts = new List<Post>();

        public void LoadPage()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load("https://maplestory.nexon.net/news");
            var newsWrapper = doc.DocumentNode.SelectNodes("//div[@class='news-wrapper']").ToList();

            foreach (var news in newsWrapper)
            {

                var li = news.Descendants("li");

                foreach (var newsItem in li)
                {
                    var photoClass = newsItem.SelectNodes(".//div[@class='photo']").ToList();
                    string backgroundImage = "";
                    string link = "";
                    string label = "";
                    string title = "";
                    string description = "";

                    foreach (var photoInfo in photoClass)
                    {
                        backgroundImage = Regex.Match(photoInfo.Attributes["style"].Value, @"(?<=url\()(.*)(?=\))").Groups[1].Value;
                        link = photoInfo.SelectSingleNode(".//a").Attributes["href"].Value;
                        label = photoInfo.SelectSingleNode(".//div[@class='label']").InnerText;
                    }

                    var textClass = newsItem.SelectNodes(".//div[@class='text']").ToList();

                    foreach (var textInfo in textClass)
                    {
                        title = textInfo.SelectSingleNode(".//h3").SelectSingleNode(".//a").InnerText;
                        description = textInfo.SelectSingleNode(".//p").InnerText;
                    }
                    SavePost(backgroundImage, link, label, title, description);
                }
            }
        }

        private void SavePost(string backgroundImage, string link, string label, string title, string description)
        {
            Post post = new Post(backgroundImage, link, label, title, description);
            posts.Add(post);
        }

        public List<Post> GetPosts()
        {
            return posts;
        }

    }
}
