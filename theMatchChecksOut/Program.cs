// See https://aka.ms/new-console-template for more information
Console.WriteLine("Insert a number");
string number1=Console.ReadLine();  
double parsedNumber1=double.Parse(number1);
Console.WriteLine("Insert a second number:");
string number2=Console.ReadLine();
double parsedNumber2=double.Parse(number2);
double result=parsedNumber1+parsedNumber2;
Console.WriteLine($"The result is :{parsedNumber1}+{parsedNumber2}={result}");
