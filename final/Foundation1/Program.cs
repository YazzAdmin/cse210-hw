using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._title = "Five Steps to Go From Average To Fortune";
        video1._author = "Jim Rohn";
        video1._length = 55;
        

        Video video2 = new Video();
        video2._title = "Career,Life and Leadership";
        video2._author = "Oprah Winfrey";
        video2._length = 75;

        Video video3 = new Video();
        video3._title = "LaLaLaLa";
        video3._author = "Straykids";
        video3._length = 85;

        video1._comments.Add(new Comment { _personName = "Karol", _text = "This is something that I needed to know!" });
        video1._comments.Add(new Comment { _personName = "Shelly", _text = "Let's put this to practice." });
        video1._comments.Add(new Comment { _personName = "Sarah", _text = "Hoe convenient I ran into this video!" });
        

        video2._comments.Add(new Comment { _personName = "Sandy", _text = "Oprah has a lot of wisdom!" });
        video2._comments.Add(new Comment { _personName = "Jenny", _text = "Such powerfull lady." });
        video2._comments.Add(new Comment { _personName = "Vanessa", _text = "I love this self development videos." });

        video3._comments.Add(new Comment { _personName = "Arthur", _text = "Great music video, loved the choreography!" });
        video3._comments.Add(new Comment { _personName = "Claudia", _text = "StrayKids never disappoint!" });
        video3._comments.Add(new Comment { _personName = "Kelly", _text = "This song is on repeat for me!" });

        List<Video> videos = new List<Video>() { video1, video2, video3 };

        foreach (var video in videos)
        {
            Console.WriteLine("Title: " + video._title);
            Console.WriteLine("Author: " + video._author);
            Console.WriteLine("Length: " + video._length + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());
            Console.WriteLine("Comments:");
            foreach (var comment in video._comments)
            {
                Console.WriteLine($"~ {comment._personName}: {comment._text}");
            }
            Console.WriteLine();
        }



    

        
    
   
    }
}
