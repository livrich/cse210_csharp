using System;

class Program
{
    static void Main(string[] args)
    {   
        // Create instance of Lecture class
        Lecture l = new Lecture("How to Code 101", "Come learn the basics of coding.", "June 6", "4:45 PM", "Talented Person", 200);
        // Display each message type for Lecture object
        Console.WriteLine();
        Console.WriteLine(l.GetStandard());
        Console.WriteLine();
        Console.WriteLine(l.GetFull());
        Console.WriteLine();
        Console.WriteLine(l.GetShort());
        Console.WriteLine();


        // Create instance of Reception class
        Reception r = new Reception("Fancy Wedding", "Celebrate the wedding of the year with us.", "8/18/23", "6-8 PM", "comeToMyWedding@Wmail.com");
        // Display each message type for Reception object
        Console.WriteLine();
        Console.WriteLine(r.GetStandard());
        Console.WriteLine();
        Console.WriteLine(r.GetFull());
        Console.WriteLine();
        Console.WriteLine(r.GetShort());
        Console.WriteLine();

        // Create instance of Outdoor class
        Outdoor o = new Outdoor("Splish Splash Slide", "We are having a water party!", "Wednesday, July 12", "all day, come anytime!", "Sunny with few clouds");
        // Display each message type for Outdoor object
        Console.WriteLine();
        Console.WriteLine(o.GetStandard());
        Console.WriteLine();
        Console.WriteLine(o.GetFull());
        Console.WriteLine();
        Console.WriteLine(o.GetShort());
        Console.WriteLine();
        

      
    }
}