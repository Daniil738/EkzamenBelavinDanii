using LibraryForTask2;
double price1 = LibraryForTask2.lib.spend(50, true);
Console.WriteLine($"Цена за 50 км с грузчиками: {price1}");

double price2 = LibraryForTask2.lib.spend(150, true);
Console.WriteLine($"Цена за 150 км с грузчиками: {price2}");

double price3 = LibraryForTask2.lib.spend(50, false);
Console.WriteLine($"Цена за 50 км без грузчиков: {price3}");

double price4 = LibraryForTask2.lib.spend(150, false);
Console.WriteLine($"Цена за 150 км без грузчиков: {price4}");
