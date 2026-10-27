using System.Reflection.Metadata.Ecma335;

namespace NameGenCore;

public interface INameGen
{
    string Name();
}


public class OneNameGenerator : INameGen
{
public string Name()
    {
        return "Jessicus Stressicus";
    }
}
