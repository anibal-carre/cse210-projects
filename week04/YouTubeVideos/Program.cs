using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = [];

        Video video1 = new("Surviving 24 Hours on a Deserted Island", "Mr. Beast", 1200.0);
        video1.AddComment(new Comment("David", "You are amazing, Mr. Beast!"));
        video1.AddComment(new Comment("John", "How do you stay so calm in these challenges?"));
        video1.AddComment(new Comment("Anna", "This inspired me to try something crazy too."));
        videos.Add(video1);


        Video video2 = new("Reacting to the Funniest Memes on the Internet", "PewDiePie", 900.0);
        video2.AddComment(new Comment("Alice", "This is exactly the content I needed today."));
        video2.AddComment(new Comment("Bob", "I cried laughing at the cat meme."));
        video2.AddComment(new Comment("Charlie", "Please make more videos like this."));
        videos.Add(video2);


        Video video3 = new("Horror Game Marathon: 10 Hours of Terror!", "Markiplier", 3600.0);
        video3.AddComment(new Comment("Emily", "I don't know how you play this without screaming."));
        video3.AddComment(new Comment("Luke", "Your reaction was scarier than the game!"));
        video3.AddComment(new Comment("Sophia", "Can I join next time? I'm brave enough!"));
        videos.Add(video3);


        Video video4 = new("Building a Mansion in Minecraft with $0 Budget", "Dream", 1800.0);
        video4.AddComment(new Comment("Ethan", "The mansion turned out amazing!"));
        video4.AddComment(new Comment("Chloe", "I learned so much from your building tricks."));
        video4.AddComment(new Comment("Mason", "I definitely need to improve my building skills."));
        videos.Add(video4);

        foreach (var video in videos)
        {

            video.Display();
            Console.WriteLine("-----------------------------------------------------------------");
        }


    }
}