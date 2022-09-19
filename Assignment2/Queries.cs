namespace Assignment2;

public class Queries
{
    //Wizards invented by Rowling. Only return the names.
    public static IEnumerable<string> Query1(IEnumerable<Wizard> wizards)
    {
        return wizards.Where(wizard => wizard.Creator == "J.K. Rowling").Select(wizard => wizard.Name);
    }

    //The year the first sith lord was introduced. Let's define a sith lord to be one named Darth something.
    public static int? Query2(IEnumerable<Wizard> wizards)
    {
        return wizards.Where(wizard => wizard.Name.StartsWith("Darth")).Min(wizard => wizard.Year);
    }

    //Unique list of wizards from the Harry Potter books - only return name and year (as a value tuple).
    public static IEnumerable<(string Name, int? Year)> Query3(IEnumerable<Wizard> wizards)
    {
        return wizards.Where(wizard => wizard.Medium == "Harry Potter").GroupBy(wizard => (wizard.Name, wizard.Year))
            .Select(wizard => wizard.Key);
    }

    //List of wizard names grouped by creator in reverse order by creator name and then wizard name.
    public static IEnumerable<(string Creator, IEnumerable<string> Names)> Query4(IEnumerable<Wizard> wizards)
    {
        return wizards.GroupBy(wizard => wizard.Creator).OrderByDescending(wizard => wizard.Key)
            .Select(wizard => (wizard.Key, wizard.Select(wizard1 => wizard1.Name)));
    }

    //Wizards invented by Rowling. Only return the names.
    public static IEnumerable<string> Query1LINQ(IEnumerable<Wizard> wizards)
    {
        return from wizard in wizards
               where wizard.Creator == "J.K. Rowling"
               select wizard.Name;
    }

    //The year the first sith lord was introduced. Let's define a sith lord to be one named Darth something.
    public static int? Query2LINQ(IEnumerable<Wizard> wizards)
    {
        return (from wizard in wizards
                where wizard.Name.StartsWith("Darth")
                select wizard.Year).Min();
    }

    //Unique list of wizards from the Harry Potter books - only return name and year (as a value tuple).
    public static IEnumerable<(string Name, int? Year)> Query3LINQ(IEnumerable<Wizard> wizards)
    {
        return from wizard in wizards
               where wizard.Medium == "Harry Potter"
               group wizard by (wizard.Name, wizard.Year) into wizard
               select wizard.Key;
    }

    //List of wizard names grouped by creator in reverse order by creator name and then wizard name.
    public static IEnumerable<(string Creator, IEnumerable<string> Names)> Query4LINQ(IEnumerable<Wizard> wizards)
    {
        return from wizard in wizards
               group wizard by wizard.Creator into wizard
               orderby wizard.Key descending
               select (wizard.Key, from wizard1 in wizard
                                   select wizard1.Name);
    }
}
