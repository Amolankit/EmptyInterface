namespace EmptyInterfaceSample.SuperTypeInterfaceSample.BlankInterfaceImplementation;

// Supertype Interface for Editions
public interface IEdition { }

// Concrete Edition Implementations
public class FirstEdition : IEdition
{
    public int EditionNumber { get; set; } = 1;
}

public class MonthlyEdition : IEdition
{
    public DateTime Month { get; set; }
}

// Book Release that uses Editions
public class BookRelease
{
    public IEdition Edition { get; set; }

    public void PrintEditionDetails()
    {
        if (Edition is FirstEdition firstEdition)
        {
            Console.WriteLine($"First Edition - Edition Number: {firstEdition.EditionNumber}");
        }
        else if (Edition is MonthlyEdition monthlyEdition)
        {
            Console.WriteLine($"Monthly Edition - Month: {monthlyEdition.Month.ToString("MMMM yyyy")}");
        }
    }
}
