// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello!");
Console.WriteLine("What do you want to do");

var userChoice = Console.ReadLine();

if (userChoice.Length <= 3) 
{
    Console.WriteLine("short answer");
}  if (userChoice.Length<10)
{
    Console.WriteLine("longer than three");
} else
{
    Console.WriteLine("longer ooo");
}

Console.ReadKey();






