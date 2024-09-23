// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajalt valida tema sugu (m/f)
//rakendus küsib kasutjal sisestada tema perekonnanime
//lähtudes kasutaja valikust rakendus tervitab kasutajat järgmiselt:
// "Welcome, Mr [kasutaja perekonnanimi]" / "Welcome, Ms [kasutaja perekonnanimi]"

Console.WriteLine("Plese, select your gender (m/f):" );

char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid string (sõned) formaadis
Console.WriteLine("Please, eneter your lastname:");

string userLastName = Console.ReadLine();


if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}
