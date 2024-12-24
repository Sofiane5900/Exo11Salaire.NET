using Exo11Salaire.NET;

Salarié chloé = new Salarié(18232, "Cantine", "Chloé", 24000 );
Salarié emma = new Salarié(18232, "Bureau", "Emma", 26000);
Salarié goerges = new Salarié(18232, "Informatique", "Goerges", 28000);

List<Salarié> listeSalariés = new List<Salarié>();
listeSalariés.Add(chloé);
listeSalariés.Add(emma);
listeSalariés.Add(goerges);

foreach (Salarié s in listeSalariés)
{
    Console.WriteLine(s);
}

 void AfficherSalaire()
{
    Console.WriteLine();
}