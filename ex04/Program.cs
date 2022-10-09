/*
double result;

result = 0;

for (int i = 1; i <= 10; i++)
{
  Console.WriteLine(i);
}
Console.WriteLine("\n\n\n");

int count;

count = 0;

Console.WriteLine("How many numbers ?");
count = Convert.ToInt32(Console.ReadLine());
for (int j = 1; j <= count; j++)
{
  result = Math.Pow(2, j);
  Console.WriteLine(result);
}
Console.WriteLine("\n\n\n");

Random numberGen = new Random();

int roll = 0;
int attempts= 0;

Console.WriteLine("Press enter to roll the dice.");

while(roll != 6)
{
  Console.ReadKey();

  roll = numberGen.Next(1, 7);
  Console.WriteLine("You rolled a : " + roll);
  attempts ++;
}

Console.WriteLine("It took you " + attempts + "to roll a " + roll);
*/

int dice1;
int dice2;
int attempts2;

dice1 = 0;
dice2 = 1;
attempts2 = 0;

Random numberGEN = new Random();

Console.WriteLine("Press enter to roll the dice.");

while(dice1 != dice2)
{
  Console.ReadKey();

  dice1 = numberGEN.Next(1, 7);
  dice2 = numberGEN.Next(1, 7);
  Console.WriteLine("You Rolled a " + dice1);
  Console.WriteLine("You Rolled a " + dice2);
  Console.Write("\n");
  attempts2++;
}

Console.WriteLine("I took you " + attempts2 + " to roll two dice with the same number");

Console.ReadKey();