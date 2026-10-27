using NameGenCore;

Console.WriteLine("Hej!");
Console.WriteLine("Hur många namn vill du ha???????!!!!!!!");
Console.WriteLine("Hej! Välkommen till namn generatorn. Hur många namn ska jag generera åt dig? ");
Console.WriteLine("När behöver vi sova");
INameGen nameGenerator = new OneNameGenerator();
Console.WriteLine(nameGenerator.Name());