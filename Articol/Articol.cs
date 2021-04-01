using System;
using System.Collections.Generic;
using System.Text;

namespace Articol
{
    class Articol
    {
        #region Private Members
        private string title, content, tag;
        private List<string> authors = new List<string>();
        DateTime datePosted, dateLastUpdate;
        private static Random rnd = new Random();
        private int likes = rnd.Next(0, 10000);
        private int dislikes = rnd.Next(0, 10000);
        #endregion

        #region Constructor
        public Articol(string title, string content, List<string> authors, DateTime datePosted, DateTime dateLastUpdate, string tag)
        {
            this.title = title;
            this.content = content;
            this.authors = authors;
            this.datePosted = datePosted;
            this.dateLastUpdate = dateLastUpdate;
            this.tag = tag;
        }
        #endregion

        #region Likes/Dislikes
        public int Likes { get { return likes; } }
        public int Dislikes { get { return dislikes; } }
        #endregion

        #region Properties
        public string Title { get { return title; } }
        public string Content { get { return content; } }
        public string Tag { get { return tag; } }
        public List<string> Authors { get { return authors; } }
        public DateTime DatePosted { get { return datePosted; } }
        public DateTime DateLastUpdate { get { return dateLastUpdate; } }
        #endregion

        public string returnAuthorsInString()
        {
            string autor = "";

            for (int i = 0; i < authors.Count - 1; i++)
                autor += authors[i] + ", ";
            autor += authors[authors.Count - 1];

            return autor;
        }

        public override string ToString()
        {
            return $"{title} by {returnAuthorsInString()} \nDate Posted: {datePosted}\n\n{content}\n\n";
        }
    }
}
