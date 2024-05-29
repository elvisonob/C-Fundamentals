Console.WriteLine("[R]emove a todo");
Console.WriteLine("[E]xit");

var word = Console.ReadLine();

while (word.Length < 15)
{
    word += "a";
    Console.WriteLine(word);
    Console.WriteLine("the loop is finished");
}

Console.ReadKey();




//if (userChoice == "S")
//{
//    PrintSelectedOption("See all TODOS");
//}
//else if (userChoice == "R")
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

//Console.ReadKey();

//void PrintSelectedOption(string activity)
//{
//    Console.WriteLine(activity);
//}