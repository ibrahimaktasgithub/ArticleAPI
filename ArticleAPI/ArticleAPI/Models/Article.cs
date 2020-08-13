using System;
using System.Collections.Generic;

namespace ArticleAPI.Models
{
    public partial class Article
    {
        public Article()
        {
            Post = new HashSet<Post>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }
        public string Slug { get; set; }

        public ICollection<Post> Post { get; set; }
    }
}
