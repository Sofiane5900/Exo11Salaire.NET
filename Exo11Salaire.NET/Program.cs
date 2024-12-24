using System.ComponentModel.Design;
using Exo11Salaire.NET;

Salarié chloé = new Salarié(18232, "Cantine", "Chloé", 24000 );
Salarié emma = new Salarié(25424, "Bureau", "Emma", 26000);
Salarié goerges = new Salarié(1182, "Informatique", "Goerges", 28000);

List<Salarié> listeSalariés = new List<Salarié>();
listeSalariés.Add(chloé);
listeSalariés.Add(emma);
listeSalariés.Add(goerges);

while (true)
{
    Console.WriteLine("---Menu Salariées--");
}

foreach (Salarié s in listeSalariés)
{
    AfficherSalaire(s);
}

 void AfficherSalaire(Salarié salarié)
{
    Console.WriteLine($"Le salaire de {salarié.Nom} (matricule: {salarié.Matricule}) est de {salarié.Salaire} euros.");
}