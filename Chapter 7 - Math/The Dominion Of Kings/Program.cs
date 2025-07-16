int provinces, duchies, estates;

Console.WriteLine("How many provinces are there?");
provinces = int.Parse(Console.ReadLine());
Console.WriteLine("How many dutchies are there?");
duchies = int.Parse(Console.ReadLine());
Console.WriteLine("How many estates are there?");
estates = int.Parse(Console.ReadLine());

int totalPoints = (provinces * 6) + (duchies * 3) + estates;
Console.WriteLine($"Total points: {totalPoints}");    