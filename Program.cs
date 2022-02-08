// See https://aka.ms/new-console-template for more information
using System;

class Program {        

    static void Main(string[] args)

    {
        string myName = "Gareth"; //this is where i set the name
        Console.WriteLine(myName==new string("Gareth"));
        Console.WriteLine(myName.Equals("Gareth"));
        myName = "James";
    }

}

