using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instance of Lecture class
        Lecture l = new Lecture("How to Code 101", "Come learn the basics of coding.", "June 6", "4:45 PM", "My House", "Me", 20);
        // Display each message type for Lecture object
        Console.WriteLine(l.GetStandard());
        Console.WriteLine();
        Console.WriteLine(l.GetFull());
        Console.WriteLine();
        Console.WriteLine(l.GetShort());
        Console.WriteLine();


        // Create instance of Reception class
        Reception r = new Reception("Nobel Wedding", "Celebrate the wedding of the year with us.", "8/18/23", "6-8 PM", "Fancy Venue", "comeToMyWedding@Wmail.com");
        // Display each message type for Reception object
        Console.WriteLine(r.GetStandard());
        Console.WriteLine();
        Console.WriteLine(r.GetFull());
        Console.WriteLine();
        Console.WriteLine(r.GetShort());
        Console.WriteLine();

        // Create instance of Outdoor class
        Outdoor o = new Outdoor("Splish Splash Slide", "We are having a water party!", "Wednesday, July 12", "All day, come anytime!", "Cool Party House", "Sunny with few clouds");
        // Display each message type for Outdoor object
        Console.WriteLine(o.GetStandard());
        Console.WriteLine();
        Console.WriteLine(o.GetFull());
        Console.WriteLine();
        Console.WriteLine(o.GetShort());
        Console.WriteLine();
        

      
    }
}