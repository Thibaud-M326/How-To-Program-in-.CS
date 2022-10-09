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

Console.ReadKey();