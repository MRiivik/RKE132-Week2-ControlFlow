// See https://aka.ms/new-console-template for more information

// Rakendus küsib kasutajal küsida tema sugu: mees või naine
// Rakendus küsib kasutajalt tema perekonnanime
// Lähtudes valikust tervitab programm kasutajat vastavalt:
// Welcome "mr./ms. [Kasutaja perekonnanimi]!"

Console.WriteLine("Please select your gender (m/f):");

Char userGender = Char.Parse (Console.ReadLine()); // Loeb konsoolist maha andmeid string (sõne) formaadis
Console.WriteLine("Please enter your last name:");

string userLastName = Console.ReadLine ();  

if(userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}