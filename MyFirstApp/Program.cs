// This is a comment to my code

//Rakendus palub kasutajal sisestada oma nimi
//Pärast nime sisestamist tervitatakse kasutajat nimepidi

Console.WriteLine("Enter your name:"); // väljund
//string - sõne
string userName = Console.ReadLine(); //sisend

Console.WriteLine("Hello" + ", " + userName + "!"); //väljund

// string interpolation
Console.WriteLine($"Hello, {userName} !"); //väljund