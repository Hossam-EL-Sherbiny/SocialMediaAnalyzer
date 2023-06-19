// Create social media posts
using SocialMediaAnalyzer;

List<Post> posts = new List<Post>
        {
            new Post
            {
                Text = "Excited for the new movie! #Avengers #Marvel",
                Hashtags = new List<string> { "#Avengers", "#Marvel" },
                Mentions = new List<string> { "@RobertDowneyJr" },
                Likes = 10
            },
            new Post
            {
                Text = "Just had a great workout at the gym! #Fitness #Health",
                Hashtags = new List<string> { "#Fitness", "#Health" },
                Mentions = new List<string>(),
                Likes = 5
            },
            new Post
            {
                Text = "Happy birthday to my best friend! @Emily",
                Hashtags = new List<string>(),
                Mentions = new List<string> { "@Emily" },
                Likes = 20
            },
            new Post
            {
                Text = "Feeling motivated today! #MondayMotivation",
                Hashtags = new List<string> { "#MondayMotivation" },
                Mentions = new List<string>(),
                Likes = 8
            }
        };

        SocialAnalyzer analyzer = new SocialAnalyzer(posts);   

        // Filter by hashtag
        string hashtag = "#Fitness";
        List<Post> filteredByHashtag = analyzer.FilterByHashtag(hashtag);
        Console.WriteLine($"Posts filtered by hashtag {hashtag}:");
        foreach (var post in filteredByHashtag)
        {
            Console.WriteLine(post.Text);
        }
        Console.WriteLine();

        // Calculate total likes
        int totalLikes = analyzer.CalculateTotalLikes();
        Console.WriteLine($"Total likes: {totalLikes}");
        Console.WriteLine();

        SentimentAnalyzer sentimentAnalyzer = new SentimentAnalyzer();

        // Sentiment analysis
        string text = "I love this place!";
        string sentiment = sentimentAnalyzer.AnalyzeSentiment(text);
        Console.WriteLine($"Sentiment of the text '{text}': {sentiment}");
        Console.WriteLine();

        ReportGenerator reportGenerator = new ReportGenerator();

        // Generate hashtag report
        reportGenerator.GenerateHashtagReport(posts);

        // Generate user engagement report
        reportGenerator.GenerateUserEngagementReport(posts);
