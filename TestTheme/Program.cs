Console.WriteLine("Quante persone partecipano?");
int numeroPartecipanti = int.Parse(Console.ReadLine());

Console.WriteLine("Persone a cui piace la Trap: ");
float fanTrap = float.Parse(Console.ReadLine());
Console.WriteLine("Persone a cui piace il Metal: ");
float fanMetal = float.Parse(Console.ReadLine());
Console.WriteLine("Persone a cui piace il Rock: ");
float fanRock = float.Parse(Console.ReadLine());
Console.WriteLine("Persone a cui piace la Techno: ");
float fanTechno = float.Parse(Console.ReadLine());

Console.WriteLine("---------------------STATS---------------------");
Console.WriteLine((fanTrap/numeroPartecipanti) * 100f + "%");
Console.WriteLine((fanMetal/numeroPartecipanti) * 100f + "%");
Console.WriteLine((fanRock / numeroPartecipanti) * 100f + "%");
Console.WriteLine((fanTechno / numeroPartecipanti) * 100f + "%");
Console.WriteLine("-----------------------------------------------");
