using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        Video firstVideo = new Video("The Chicken Guy", "Andoks", 300);
        Comment firstComment = new Comment("Maria", "Nice Video!");
        Comment secondComment = new Comment("Joe", "Chickens don't die!");
        Comment thirdComment = new Comment("Mike", "King of Fried-days!");

        Video secondVideo = new Video("Pride and Envy", "Gary", 900);
        Comment fourthComment = new Comment("Sam", "Ain't Jealous no more!");
        Comment fifthComment = new Comment("Jane", "Gotta be Humble now");
        Comment sixthComment = new Comment("Sarah", "I hope she sees this!");

        Video thirdVideo = new Video("The Lost Humanity", "Antonio", 500);
        Comment seventhComment = new Comment("Miguel", "So, monkeys are real.");
        Comment eightComment = new Comment("John", "No way we are more inferior than monkeys.");
        Comment ninthComment = new Comment("Charles", "Monke is my grandfather.");

        firstVideo.AddComment(firstComment);
        firstVideo.AddComment(secondComment);
        firstVideo.AddComment(thirdComment);
        secondVideo.AddComment(fourthComment);
        secondVideo.AddComment(fifthComment);
        secondVideo.AddComment(sixthComment);
        thirdVideo.AddComment(seventhComment);
        thirdVideo.AddComment(eightComment);
        thirdVideo.AddComment(ninthComment);

        List<Video> videos = new List<Video>();
        
        videos.Add(firstVideo);
        videos.Add(secondVideo);
        videos.Add(thirdVideo);
        
        foreach (Video video in videos){
            Console.WriteLine($"Title: {video.GetTitle()} | Author: {video.GetAuthor()} | Length: {video.GetLength()}s.");
            Console.WriteLine($"Number of Comments: {video.NumberOfComments()}");
            Console.WriteLine($"Comment: ");

            foreach (Comment comment in video.GetComment())
            {
                Console.WriteLine($"{comment.GetName()}: {comment.GetText()}");
            }
            Console.WriteLine();
        }

    }
}