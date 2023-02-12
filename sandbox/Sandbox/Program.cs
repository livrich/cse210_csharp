using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        string str = "Olivia";
        foreach (char character in str){
            string c = character.ToString();
            if (c == "_")
            {
                continue;
            }
            else 
            {
                str = str.Replace(c, "_");
                Console.WriteLine(str);
            }
        }
        
    }
}