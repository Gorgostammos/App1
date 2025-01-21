// See https://aka.ms/new-console-template for more information
using System.Globalization;

double myNumber1 = 0.0;
double myNumber2 = 0.0;

//Printer ut
Console.WriteLine("Skriv en nummer ");

//tar imot brukrenst input 
string userInput = Console.ReadLine();

//myNumber = int.Parse(Console.ReadLine());

myNumber1 = double.Parse(userInput, CultureInfo.InvariantCulture);


Console.WriteLine("Skriv en andre nummer ");

string userInput2 = Console.ReadLine();

myNumber2 = double.Parse(userInput2, CultureInfo.InvariantCulture);


double result = myNumber1 + myNumber2;
result = Math.Round(result, 2);


//andre måter å skrive det på der vi ikke trenger å bruke result delen
//Console.WriteLine((myNumber) + (myNumber2));
//Console.WriteLine("du skrev " + " " + myNumber + " + " + " " + myNumber2);

//String interpolation
Console.WriteLine($"du skrev {myNumber1} + {myNumber2}");


Console.WriteLine($"Resultet er {myNumber1.ToString(CultureInfo.InvariantCulture)} " +
    $"and {myNumber2.ToString(CultureInfo.InvariantCulture)} is {result.ToString(CultureInfo.InvariantCulture)}");

Console.ReadKey();
