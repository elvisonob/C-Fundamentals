// See https://aka.ms/new-console-template for more information
using System.Reflection.Emit;

Console.WriteLine("Hello!");
Console.WriteLine("Input the first number:");
string firstNumber = Console.ReadLine();
int inputedNumber = int.Parse(firstNumber);

Console.WriteLine("Input the second number:");
string secondNumber = Console.ReadLine();
int inputedNumber2 = int.Parse(secondNumber);

Console.WriteLine("What do you want to do?");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubtract numbers");
Console.WriteLine("[M]ultiply numbers");

string userChoice = Console.ReadLine();


if (EqualToUpperOrLowerCase("m", "M")) 

{
    var result = inputedNumber * inputedNumber2;
   

    FunctionMethod(inputedNumber, " * ", inputedNumber2, " = ", result);
}

else if (EqualToUpperOrLowerCase("s", "S")) 
{
    var result = inputedNumber - inputedNumber2;

    FunctionMethod(inputedNumber, " - ", inputedNumber2, " = ", result);
}

else if (EqualToUpperOrLowerCase("a", "A")) 
{
    var result = inputedNumber + inputedNumber2;
    FunctionMethod(inputedNumber, "+", inputedNumber2, " = ", result);
}

else
{
    Console.WriteLine("invalid choice");
}

void FunctionMethod(int number, string @operator, int number2,  string equalTo, int answer)
{
    Console.WriteLine( number + @operator + number2 + equalTo + answer);
}

bool EqualToUpperOrLowerCase( string left, string right)
{
    return left.ToUpper() == right.ToUpper();
}

Console.ReadKey();

