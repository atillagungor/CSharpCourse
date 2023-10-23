string [] students = new string[3];
students[0] = "Engin";
students[1] = "Atilla";
students[2] = "Umut";

string[] students2 = {"Engin","Atilla","Umut"};

foreach (var student in students2)
{
    //Console.WriteLine(student);
}


string[,] regions = new string[5, 3]
{
    {"İstanbul","İzmit","Balıkesir"},
    {"Trabzon","Rize","Ordu" },
    {"İzmir", "Aydın", "Muğla" },
    {"Antalya","Adana","Mersin"},
    {"Ankara","Konya","Kırıkkale" }
};

for (int i = 0; i <= regions.GetUpperBound(0); i++)
{
    for (int j = 0; j <= regions.GetUpperBound(1); j++)
    {
        Console.WriteLine(regions[i,j]);
    }
    Console.WriteLine("--------------");
}

Console.ReadLine();