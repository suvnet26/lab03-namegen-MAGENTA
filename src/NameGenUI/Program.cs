using NameGenCore;

Console.WriteLine("Hej! Välkommen till namn generatorn.");
Console.WriteLine("Välj din namngenerator nedan:");
Console.WriteLine("1: Fantasy name");
Console.WriteLine("2: Nickname");
Console.WriteLine("3: Pirate name");
Console.WriteLine("4: Avsluta");


INameGen nameGenerator = null;

bool MenuLoop = true;

while (MenuLoop)
{
switch (Console.ReadLine())
{
    case "1":
            {
               Console.WriteLine("Ditt val: 1");
               nameGenerator = new Fantasyname();
               Console.WriteLine($"Ditt namn är {nameGenerator.Name()}!");
               break; 
            }
                case "2":
            {
               Console.WriteLine("Ditt val: 2");
               nameGenerator = new Nicknames();
               Console.WriteLine($"Ditt namn är {nameGenerator.Name()}!");
               break; 
            }
                case "3":
            {
               Console.WriteLine("Ditt val: 3");
               nameGenerator = new PirateNameGenerator();
               Console.WriteLine($"Ditt namn är {nameGenerator.Name()}!");
               break; 
            }

                case "4":
            {
                Console.WriteLine("Ditt val: 4");
                Console.WriteLine("Programmet avslutas");
                MenuLoop = false;
                break;
            }
    
    default:
    break;
}
}
// Console.WriteLine(nameGenerator.Name());