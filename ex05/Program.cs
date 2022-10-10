/*
int i;
int rank;
i = 0;
rank = 0;

string[] movies = {"Seigneurs des Anneaux", "Alien Covenant", "Ready Player One", "Interstellar",
"Charlie et la Chocolaterie"};

while(i < movies.Length)
{
  rank = i + 1;
  Console.WriteLine(rank + ". " + movies[i]);
  i++;
}
*/
/*
string[] movies = new string[4];

Console.WriteLine("Quels sont vos quatres films préférés ?");

for (int i = 0; i < movies.Length; i++)
{
  movies[i] = Console.ReadLine();
}

Console.WriteLine("\nLes voila par ordre alphabetique:\n");

Array.Sort(movies);

for(int i = 0; i < movies.Length; i++)
{
  Console.WriteLine(movies[i]);
}
*/
/*
using System.Collections.Generic;

List<string> shoppingList = new List<string>();

shoppingList.Add("Dreams");
shoppingList.Add("Miracle");
shoppingList.Add("Rainbows");
shoppingList.Add("Poney");

for (int i = 0; i < shoppingList.Count; i++)
{
  Console.WriteLine(shoppingList[i]);
}

shoppingList.Remove("Dreams");
shoppingList.RemoveAt(1);

Console.WriteLine("---------------------------");

for (int i = 0; i < shoppingList.Count; i++)
{
  Console.WriteLine(shoppingList[i]);
}
*/
/*
int count;

count = 0;

Console.WriteLine("How many student ?");

count = Convert.ToInt32(Console.ReadLine());

string[] students = new string[count];

Console.WriteLine("\nNames:");

for (int i = 0; i < count; i++)
{
  students[i] = Console.ReadLine();
}

Array.Sort (students);

Console.WriteLine("\nIN Alphabetial order:");

for (int i = 0; i < count; i++)
{
  Console.WriteLine(students[i]);
}
*/

using System.Collections.Generic;
int count;

count = 0;

Console.WriteLine("Bonjour ya combien d'eleves ?");

count = Convert.ToInt32(Console.ReadLine());

List <string> students = new List<string>();  

for (int i = 0; i < count; i++)
{
  students.Add(Console.ReadLine());
}

Console.WriteLine("c'est eux attrapez les:");
students.Sort();

for (int i = 0; i < students.Count; i++)
{
  Console.WriteLine(students[i]);
}


Console.ReadKey();