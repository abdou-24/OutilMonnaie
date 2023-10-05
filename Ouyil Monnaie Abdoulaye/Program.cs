// See https://aka.ms/new-console-template for more information
//Variable : Euro 
Console.WriteLine("Bonjour! Quel type de monnaie voulez-vous utiliser? (choix : euro, cad , usd)");

string line = Console.ReadLine();

Console.WriteLine("Comme vous avez choisi l'/le " + line + " choisissez le type de monnaie dont vous_voulez faire la conversion ");

string line2 = Console.ReadLine();

Console.WriteLine("Écrvivez le montant en " + line + " que vous voulez convertir en " + line2 + "");

double montant = Convert.ToDouble(Console.ReadLine());

double montantconverti = 0;

if (line == "cad" && line2 == "usd")

{
     montantconverti = montant / 1.35017633;

}

if (line == "usd"  && line2 == "cad")

{

     montantconverti = montant * 1.35017633;

}


if (line == "cad" && line2 == "euro")

{

     montantconverti = montant * 1.42857143;

}



if (line == "usd" && line2 == "euro")

{

     montantconverti = montant / 1.05263158;

}


if (line == "euro" && line2 == "cad")

{

     montantconverti = montant * 1.42857143;

}


 if  (line == "euro" && line2 == "usd")

{

     montantconverti = montant * 1.05263158;

}


Console.WriteLine("Votre montant de " + montant + " sera dorénanvant " + montantconverti + " en " + line2 + "");

Console.ReadKey();