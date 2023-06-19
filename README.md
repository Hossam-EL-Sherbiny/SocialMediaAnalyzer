# Social Media Data Analyzer
This is a project created to practice social media data analysis.
The program analyzes social media data, such as posts or tweets, and provides insights based on various parameters like hashtags, mentions, user interactions, and sentiment analysis.

## Overview
The Social Media Data Analyzer program is developed using C# and utilizes LINQ for filtering and analyzing the social media data. It consists of the following components:

- `Post`: Represents a social media post with properties like text, hashtags, mentions, and likes.
- `SocialMediaAnalyzer`: Performs filtering and analysis on the social media posts, including filtering by hashtag, calculating total likes, and generating reports.
- `SentimentAnalyzer`: Analyzes the sentiment of the text using positive and negative keywords.
- `ReportGenerator`: Generates reports based on the social media data, such as hashtag report and user engagement report.

## Motivation
I created this project to practice and apply the concepts and techniques I have learned in social media data analysis.
It allowed me to gain hands-on experience with C#, LINQ, and object-oriented programming.
By developing this program, I aimed to solidify my understanding of data filtering, analysis, and generating reports from social media data.

## Getting Started
To use this program, follow these steps:

1. Clone the repository: `git clone https://github.com/your-username/social-media-data-analyzer.git`
2. Open the project in your preferred C# development environment (e.g., Visual Studio).
3. Build the project to restore dependencies and compile the code.
4. Modify the sample data in the `Main` method of the `Program` class with your own social media data or use it as a reference to create your own data structures.
5. Run the program to see the analysis and insights generated based on the provided data.

## Usage
The main functionality of the Social Media Data Analyzer program is demonstrated in the `Main` method of the `Program` class. It performs the following actions:
1. Creates a list of social media posts with sample data.
2. Creates an instance of the `SocialMediaAnalyzer` class and performs filtering and analysis on the social media data, including filtering by hashtag, calculating total likes, and sentiment analysis.
3. Creates an instance of the `ReportGenerator` class and generates reports based on the social media data, such as hashtag report and user engagement report.

## Dependencies
This program does not have any external dependencies. It is built using C# and utilizes LINQ for data analysis.

## License
This project is licensed under the [MIT License](LICENSE).

