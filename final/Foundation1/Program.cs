using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 =new Video();
        video1._title = "Five Steps to Go From Average To Fortune";
        video1._author = "Jim Rohn";
        video1._length = 55;

        Video video2 =new Video();
        video2._title= "Career, Life and Leadership";
        video2._author ="Oprah Winfrey";
        video2._length = 75;

        Video video3= new Video();
        video3._title = "LaLaLaLa";
        video3._author= "Straykids";
        video3._length = 85;

        video1._comments.Add(new Comment{_personName= "Karol", _text ="This is something that I needed to know!"});
        video1._comments.Add(new Comment{_personName= "Shelly", _text ="Let's put this to practice."});
        video1._comments.Add(new Comment{_personName= "Sarah", _text ="How I needed to hear this, I am so happy I ran into this video!"});
        

        video2._comments.Add(new Comment{_personName= "Sandy", _text ="Oprah has a lot of wisdom!"});
        video2._comments.Add(new Comment{_personName= "Jenny", _text ="Such a powerfull lady!"});
        video2._comments.Add(new Comment{_personName= "Vanessa", _text ="I love this self-development videos."});

        video3._comments.Add(new Comment{_personName= "Arthur", _text ="Great music video! I loved the choreography!"});
        video3._comments.Add(new Comment{_personName= "Claudia", _text ="StrayKids never disappoint!"});
        video3._comments.Add(new Comment{_personName= "Kelly", _text ="I could listen to this song, over and over!"});

        List<Video> videos =new List <Video>(){video1,video2,video3};

        foreach(var video in videos)
        {
           video.Display();
        }



    

        
    
   
    }
}
