//Partie 1
//talk with my name in variable
string userName;

Console.WriteLine("What is your name ?");

userName = Console.ReadLine();

Console.WriteLine("Nice " + userName + ", im happy meeting you!");

//Partie 2
Console.WriteLine("\n\n\nPart II");

double num01;
double num02;
double result;

Console.Write("Input a number:");
num01 = Convert.ToDouble( Console.ReadLine() );

Console.Write("Input a number:");
num02 = Convert.ToDouble( Console.ReadLine() );

result = num01 + num02;
Console.Write("The result is " + result);

//Partie 3
Console.WriteLine("\n\n\nPart III");

int N1;
int N2;
int N3;

Console.WriteLine("Input a number: ");
N1 = Convert.ToInt32( Console.ReadLine() );

Console.WriteLine("Input a number: ");
N2 = Convert.ToInt32( Console.ReadLine() );

Console.WriteLine("Input a number: ");
N3 = Convert.ToInt32( Console.ReadLine() );

result = (N1 + N2 + N3) / 3;

Console.WriteLine("result is:" + result);

//wait before closing
Console.ReadKey();