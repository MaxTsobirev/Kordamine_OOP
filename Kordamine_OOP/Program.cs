using Kordamine_OOP;
Console.WriteLine("-Koer-\n");
Koer koer = new Koer(Koer.toug.Pitbull, "Sharik", "punane", Koduloom.sugu.isane, 35.5, 7, true);
koer.print_Info();
koer.print_Haal();
Koer veelkoer = new Koer(koer);
veelkoer.muudaNimi("Sharik");
veelkoer.muudaVarv("Must");
veelkoer.muudaKaal(40);
veelkoer.muudaVanus(5);

veelkoer.print_Info();

Console.WriteLine("\n-Cats-\n");

Cats cats = new Cats(Cats.toug.cat1, "Billy", "Valge", Koduloom.sugu.isane, 10, 2, true);
cats.print_Info();
cats.print_Haal();

Cats veelcats = new Cats(cats);
veelcats.muudatNimi("kot");
veelcats.muudatVarv("Valge");
veelcats.muudatKaal(36);
veelcats.muudatVanus(2);

veelcats.print_Info();

string file = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Koduloom_info.txt");
using (StreamWriter text = new StreamWriter(file))
{
    text.WriteLine("-Koer-\n");
    text.WriteLine("{0} {1} {2} ta on {3} ja tema kaal on {4} kg. ja ta on {5} aastat vana", koer.Toug, koer.nimi, koer.varv, koer.loomaSugu, koer.kaal, koer.vanus);
    
    text.WriteLine("\n-Cats-\n");
    text.WriteLine("{0} cats. Nimi: {1} {2} ta on {3} ja tema kaal on {4} kg ja ta on {5} aastat vana", cats.Toug, cats.nimi, cats.varv, cats.loomaSugu, cats.kaal, cats.vanus);
}

List<Koduloom> loomad = new List<Koduloom>();
StreamReader sr = new StreamReader(@"..\..\..\Koduloom_info.txt");
string text;
while ((text = sr.ReadLine()) != null)
{
    string[] rida = text.Split(',');
    loomad.Add(new loomad(rida[0], rida[1]));
}
sr.Close();
foreach (var item in loomad)
{
    Console.WriteLine(item.nimi + " " + item.sugu);
}
Console.ReadLine();