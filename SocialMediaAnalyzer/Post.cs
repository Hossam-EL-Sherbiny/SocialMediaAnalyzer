using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaAnalyzer
{
    public class Post
    {
        public string? Text { get; set; }
        public List<string>? Hashtags { get; set; }
        public List<string>? Mentions { get; set; }
        public int Likes { get; set; }
    }
}