Console.WriteLine("[R]emove a todo");
Console.WriteLine("[E]xit");

var userChoice =Console.ReadLine();

var finalNum = int.Parse(userChoice);

switch (finalNum)
{
    case 10:
    case 9:
        PrintSelectedOption("A");
        break;

    case 8:
    case 7:
    case 6:
        PrintSelectedOption("B");
        break;

    case 5:
    case 4:
    case 3:
        PrintSelectedOption("C");
        break;

    case 2:
    case 1:
        PrintSelectedOption("D");
        break;

    case 0:
        PrintSelectedOption("E");
        break;

    default:
        PrintSelectedOption("!");
        break;



}


//if (userChoice == "S")
//{
//    PrintSelectedOption("See all TODOS");
//} else if (userChoice == "R")
//{
//    PrintSelectedOption("Remove all TODOS");
//}
//else if (userChoice == "A")
//{
//    PrintSelectedOption("Add a Todo");
//}
//else if (userChoice == "E")
//{
//    PrintSelectedOption("Exit");
//}
//else
//{
//    PrintSelectedOption("just chill");
//}

Console.ReadKey();

void PrintSelectedOption(string activity)
{
    Console.WriteLine(activity);
}