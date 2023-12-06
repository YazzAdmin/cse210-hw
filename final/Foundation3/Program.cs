using System;

class Program
{
    static void Main()
    {
        //for Addresses
        Address address1 = new Address("1313 S Disneyland Dr", "Anaheim", "California", "US");
        Address address2 = new Address("100 Universal City Plaza", "Universal City", "California", "US");
        Address address3 = new Address("1423 BVLD. Cuautemoc Sur, Davila", "Tijuana", "Baja California", "Mexico");

        //for Events
        Lecture lecture = new Lecture("What matters More Than Your Talents", "Being true to oneself for an inspiring future.", DateTime.Now, "11:00 AM", address1, "Jeff Bezos", 50);
        Reception reception = new Reception("Charity Gallery Auction", "Financial support for young adult orphans.", DateTime.Now, "6:00 PM", address2, "youngsocietysupport.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Birthday Celebration!", "The famous influencer Yerimua birthday bash", DateTime.Now, "8:00 PM", address3, "Sunny");

        // Displaying Marketing Messages
        Console.WriteLine("\n");
        Console.WriteLine("Standard Details:");
        Console.WriteLine("\n");
        Console.WriteLine("Lecture:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine("\n");
        Console.WriteLine("Reception:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine("\n");
        Console.WriteLine("Outdoor Gathering:");
        Console.WriteLine(outdoorGathering.GetStandardDetails());

        Console.WriteLine("\nFull Details:");
        Console.WriteLine("\n");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine("\n");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine("\n");
        Console.WriteLine(outdoorGathering.GetFullDetails());

        Console.WriteLine("\nShort Description:");
        Console.WriteLine("\n");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine("\n");
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine("\n");
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}