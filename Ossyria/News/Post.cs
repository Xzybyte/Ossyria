using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ossyria.News
{
    internal class Post
    {

        private string backgroundImage;
        private string link;
        private string label;
        private string title;
        private string description;

        public Post(string backgroundImage, string link, string label, string title, string description)
        {
            this.backgroundImage = backgroundImage;
            this.link = link;
            this.label = label;
            this.title = title;
            this.description = description;
        }

        public string BackgroundImage { get { return backgroundImage; } }

        public string Link { get { return link; } }

        public string Label { get { return label; } }

        public string Title { get { return title; } }   

        public string Description { get { return description; } }

    }
}
