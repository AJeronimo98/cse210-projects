using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list to hold the videos
            List<Video> videos = new List<Video>();

            // Video 1
            Video video1 = new Video("Exploring the Alps", "MountainTraveler", 450);
            video1.AddComment(new Comment("User123", "The scenery is breathtaking!"));
            video1.AddComment(new Comment("NatureLover", "I need to visit this place soon."));
            video1.AddComment(new Comment("TravelGuide", "Great tips for hiking here."));
            videos.Add(video1);

            // Video 2
            Video video2 = new Video("Classic Chocolate Cake Recipe", "BakingMaster", 800);
            video2.AddComment(new Comment("SweetTooth", "Tried it today, it was delicious!"));
            video2.AddComment(new Comment("ChefEmily", "Add a pinch of salt to enhance the flavor."));
            video2.AddComment(new Comment("Foodie99", "Can I use almond flour instead?"));
            videos.Add(video2);

            // Video 3
            Video video3 = new Video("Introduction to Python Programming", "TechAcademy", 1500);
            video3.AddComment(new Comment("CodeNewbie", "This made so much sense, thank you!"));
            video3.AddComment(new Comment("DevGuru", "Very clean explanation of variables."));
            video3.AddComment(new Comment("StudentX", "Is there a part 2 for this series?"));
            video3.AddComment(new Comment("AI_Fan", "Excellent pace for beginners."));
            videos.Add(video3);

            // Iterate through the list and display the information
            foreach (Video video in videos)
            {
                Console.WriteLine("====================================================");
                Console.WriteLine($"Title: {video.Title}");
                Console.WriteLine($"Author: {video.Author}");
                Console.WriteLine($"Length: {video.Length} seconds");
                Console.WriteLine($"Total Comments: {video.GetNumberOfComments()}");
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Comments:");

                foreach (Comment comment in video.GetComments())
                {
                    Console.WriteLine($"- {comment.Name}: {comment.Text}");
                }
                Console.WriteLine(); // Blank line for spacing
            }
        }
    }
}