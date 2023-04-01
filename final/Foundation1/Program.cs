using System;

class Program
{
    static void Main(string[] args)
    {
        // List of videos
        List<Video> videos = new List<Video>();


        // First video
        Video video1 = NewVideo();
        int i = 0;
        // Add 3 comments
        while (i < 3)
        {
            video1.AddComment();
            i ++;
        }
        // Count number of comments
        video1.CountNumComments();
        // Add to list of videos
        videos.Add(video1);


        // Blank line between getting video info
        Console.WriteLine();


        // Second video
        Video video2 = NewVideo();
        int ii = 0;
        // Add three comments
        while (ii < 3)
        {
            video2.AddComment();
            ii ++;
        }
        video2.CountNumComments();
        videos.Add(video2);


        // Blank line between getting video info
        Console.WriteLine();


        // Third video
        Video video3 = NewVideo();
        int iii = 0;
        // Add 4 comments
        while (iii < 4)
        {
            video3.AddComment();
            iii ++;
        }
        video3.CountNumComments();
        videos.Add(video3);


        // Display info and comments for each
        // video in videos list.
        DisplayVideos();


        // Function to get information for video then use
        // info to create an instance of Video class.
        // Returns Video object.
        Video NewVideo()
        {
            // User entered title
            Console.Write("Video Title: ");
            string title = Console.ReadLine();
            // User entered author
            Console.Write("Video Author: ");
            string author = Console.ReadLine();
            // User entered length (seconds)
            Console.Write("Video Length(seconds): ");
            int length = Int32.Parse(Console.ReadLine());

            Video v = new Video(title, author, length);
            return v;
        }

        // Displays info for each video in videos list.
        // For easier readability, prints blank line at beginning.
        // Calls DisplayComments function to handle comments.
        void DisplayVideos()
        {
            foreach (Video v in videos)
            {
                Console.WriteLine();
                Console.WriteLine($"\"{v.GetTitle()}\" by {v.GetAuthor()}");
                Console.WriteLine($"Duration: {v.GetLength()} seconds");
                Console.WriteLine($"{v.GetNumberComments()} Comments:");
                DisplayComments(v.GetComments());
            }
        }
        
        // Displays each comment for video.
        // For easier readability, prints blank line after each comment.
        void DisplayComments(List<Comment> comments)
        {
            foreach (Comment c in comments)
            {
                Console.WriteLine(c.GetText());
                Console.WriteLine($"- {c.GetName()}");
                Console.WriteLine();
            }
        }
    }
}