using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaAnalyzer
{
    public class SentimentAnalyzer
    {
        public string AnalyzeSentiment(string text)
        {
            text = text.ToLower();
            string[] positiveKeyWords = {"Happy", "Greate", "Awesome", "Love"};
            string[] negativeKeywords = { "sad", "bad", "terrible", "hate" };

            bool isPositve = positiveKeyWords.Any(keyword => text.Contains(keyword));
            bool isNegative = negativeKeywords.Any(keyword => text.Contains(keyword));

            if (isPositve)
                return "Positive";
            else if (isNegative)
                return "Negative";
            else
                return "Neutral";
        }
    }
}
