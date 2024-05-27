// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello!");
Console.WriteLine("Input the first number:");

string firstNumber = Console.ReadLine();

int inputedNumber = int.Parse(firstNumber);
//Console.WriteLine(firstNumber);

Console.WriteLine("Input the second number:");

string secondNumber = Console.ReadLine();

int inputedNumber2 = int.Parse(secondNumber);
//Console.WriteLine(secondNumber);

Console.WriteLine("What do you want to do?");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubtract numbers");
Console.WriteLine("[M]ultiply numbers");

string userChoice = Console.ReadLine();

/*if (userChoice != "m" || userChoice != "s" || userChoice != "a")
{
    Console.WriteLine("Invalid choice");
}*/

if (userChoice == "m" || userChoice == "M") 

{
    var result = inputedNumber * inputedNumber2;
   
    Console.WriteLine( inputedNumber  +  "*" +  inputedNumber2 +  "=" +   result);
}

if (userChoice == "s" || userChoice =="S") 
{
    var result = inputedNumber - inputedNumber2;
   
    Console.WriteLine(inputedNumber  +  "-" +   inputedNumber2 +  "=" +   result);
}

if (userChoice == "a" || userChoice =="A") 
{
    var result = inputedNumber + inputedNumber2;
    
    Console.WriteLine(inputedNumber +  "+" +   inputedNumber2 +  "=" +   result);
}

if (userChoice !="a" && userChoice != "m" && userChoice != "s")
{
    Console.WriteLine("invalid choice");
}

