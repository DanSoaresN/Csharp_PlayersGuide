Console.WriteLine("How many chocolate eggs was gathered?");
int chocolateEggs = int.Parse(Console.ReadLine());

int sistersEggs = chocolateEggs / 4;
int duckbearEggs = chocolateEggs % 4;

Console.WriteLine($"Each sister gets {sistersEggs} chocolate eggs.");
Console.WriteLine($"The duckbear gets {duckbearEggs} chocolate eggs.");