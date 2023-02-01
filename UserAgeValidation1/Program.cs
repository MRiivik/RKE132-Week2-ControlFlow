// See https://aka.ms/new-console-template for more information

//Rakendus palub kasutajal sisestada tema nime
//Kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatakse:
//"You are too young to use this program."
//Muul juhul kuvatakse konsoolis:
// "Welcome to my program!"

Console.WriteLine("Enter your age:");

string userAge = Console.ReadLine();

int userAgeNum = 0;

//boolean - true/false

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

// int userAge = Int32.Parse(Console.ReadLine()); // "13" - heap; 13 - stack

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");

if (isAgeNumber == true)
{
    if(userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to Instagram!");
    }
    else
    {
        Console.WriteLine("You are too young to use Instagram.");
    }
}
else
{
    Console.WriteLine("Could not read your age.");
}