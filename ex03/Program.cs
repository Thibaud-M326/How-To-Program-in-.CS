int cash;
int change;

cash = 0;
change = 0;

Console.WriteLine("Bonjour c'est 5Euro le Ticket vous avez combien ?");
cash = Convert.ToInt32(Console.ReadLine());

if (cash > 5)
{
    change = cash - 5;
    Console.WriteLine("Voila votre ticket et " + change + " euros merci !");
}
else if (cash == 5)
{
    Console.WriteLine("Voici votre ticket!");
}
else
{
    Console.WriteLine("C'est pas assez mon grand reviens plus tard! :)");
}

//Partie 2
int age;
int height;

Console.WriteLine("Quel est votre age ?");
age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Quel est votre taille en cm ?");
height = Convert.ToInt32(Console.ReadLine());

if (age >= 12 && height >= 120)
{
    Console.WriteLine("Vous pouvez entrer");
}
else 
{
    Console.WriteLine("C'est non !");
}
Console.WriteLine("\n\n\n");

//Partie 3
int calcul;

calcul = 0;

Console.Write("25 + 25 =");

calcul = Convert.ToInt32(Console.ReadLine());

if (calcul == 50)
{
    Console.WriteLine("Correct!");
}
else
{
    Console.WriteLine("Wrong!");
}


//Termine le programme
Console.ReadKey();