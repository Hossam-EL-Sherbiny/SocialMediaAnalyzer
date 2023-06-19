using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaAnalyzer
{
    public class ReportGenerator
    {
        public void GenerateHashtagReport(List<Post> posts)
        {
            Console.WriteLine("Hashtag Report: ");
            var hashtags = posts.SelectMany(p => p.Hashtags).Distinct();
            foreach (var hashtag in hashtags)
            {
                int count = posts.Count(p => p.Hashtags.Contains(hashtag));
                Console.WriteLine($"- {hashtag}: {count} posts");
            }
            Console.WriteLine();
        }

        public void GenerateUserEngagementReport(List<Post> posts)
        {
            Console.WriteLine("User Engagement Report:");
            var sortedPosts = posts.OrderByDescending(p => p.Likes);
            foreach (var post in sortedPosts)
            {
                Console.WriteLine($"- Post: {post.Text}");
                Console.WriteLine($"  Likes: {post.Likes}");
                // Include more engagement metrics as needed (e.g., comments, shares)
            }
            Console.WriteLine();
        }
    }

}
