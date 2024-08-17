namespace EmptyInterfaceSample.SuperTypeInterfaceSample.EvolvedInterfaceImplementation;

// Adding Method to the IEdition Interface
public interface IEdition
{
    void AdvanceEdition();
}

public class FirstEdition : IEdition
{
    public int EditionNumber { get; set; } = 1;

    public void AdvanceEdition()
    {
        EditionNumber++;
    }
}

public class MonthlyEdition : IEdition
{
    public DateTime Month { get; set; }

    public void AdvanceEdition()
    {
        Month = Month.AddMonths(1);
    }
}
