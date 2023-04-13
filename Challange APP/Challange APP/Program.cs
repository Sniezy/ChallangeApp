int Lat = 25;
string Name = ("Mati");
string sex = ("Men");

if (sex != "Men" && Lat < 25)
{
    Console.WriteLine("Kobieta poniżej 25 lat");
}
else if (Name == "Mati" && Lat == 25)
{
    Console.WriteLine("Mati, lat 25!");
}
else if (sex == "Men" && Lat > 25)
{
    Console.WriteLine("Meżczyzna powyżej lat 25");
}