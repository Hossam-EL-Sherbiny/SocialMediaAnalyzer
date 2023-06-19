using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaAnalyzer
{
    public class SocialAnalyzer
    {
            private readonly List<Post> posts;
            public SocialAnalyzer(List<Post> postsParam)
            {
                this.posts = postsParam;
            }

            public List<Post> FilterByHashtag(string hashtag)
            {
                return
                    posts.Where(p => p.Hashtags.Contains(hashtag)).ToList();
            }

            public List<Post> FilterByMention(string mention)
            {
                return
                    posts.Where(p => p.Mentions.Contains(mention)).ToList();
            }

            public int CalculateTotalLikes()
            {
                return
                    posts.Sum(p => p.Likes);
            }
    }
}
