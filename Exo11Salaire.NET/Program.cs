using System.ComponentModel.Design;
using Exo11Salaire.NET;


Salarié chloé = new Salarié(18232, "Cantine", "Chloé", 10000002);
Salarié emma = new Salarié(25424, "Bureau", "Emma", 26000);
Salarié goerges = new Salarié(1182, "Informatique", "Goerges", 28000);

List<Salarié> listeSalariés = new List<Salarié>();
listeSalariés.Add(chloé);
listeSalariés.Add(emma);
listeSalariés.Add(goerges);
int nombresSalariés = 0;
int salaireTotal = 0;
bool estVide = false;


while (true)
{
    Console.WriteLine("---Menu Salariées--");
    Console.WriteLine("0-- Quitter l'application");
    Console.WriteLine("1-- Afficher tout les salariées");
    Console.WriteLine("2-- Afficher le montant total");
    Console.WriteLine("3-- Remettre a zero les données");


    Console.Write("Choisisez une option : ");
    int choix;  
    bool success = int.TryParse(Console.ReadLine(), out choix);
    if(!success)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Vous n'étes pas autorisée a faire cette action. ");
        Console.ResetColor();
        continue;
    }

    switch(choix)
    {
        case 0:
            Environment.Exit(0);
            break;
        case 1:
            Console.Clear();
            if (estVide == true)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Les données on etait renitialisées, je ne peux afficher les salariées");
                    Console.ResetColor();
                } else
                {
                foreach (Salarié s in listeSalariés)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    AfficherSalaire(s);
                    Console.ResetColor();
                }
            }
            break;
        case 2:
            AfficherEntreprise();
            break;
        case 3:
            RemiseAZero();
            break;
        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Veuillez faire un choix correct.");
            Console.ResetColor();
            break;
    }
}



 void AfficherSalaire(Salarié salarié)
{
    Console.WriteLine($"Le salaire de {salarié.Nom} (matricule: {salarié.Matricule}) est de {salarié.Salaire} euros.");
}

void AfficherEntreprise()
{
    for (int i = 0; i < listeSalariés.Count; i++)
    {
         nombresSalariés = i + 1;
        // J'utilise la méthode Sum pour que chaque item s d'attribut Salaire sois ajouter a ma valeur SalaireTotal
        salaireTotal = listeSalariés.Sum(s => s.Salaire);
    }
    if (estVide == true)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Les données on etait renitialisées, je ne peux afficher le montal total de l'entreprise.");
        Console.ResetColor();
    } else
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Le montant total des salaires des {nombresSalariés} employées est de {salaireTotal} euros.\n");
        Console.ResetColor();
    }
}

void RemiseAZero()
{
    Console.Clear();
    listeSalariés.Clear();
    estVide = true;
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Les données on était remis a zero !");
    Console.ResetColor();
}