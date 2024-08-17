namespace EmptyInterfaceSample.SuperTypeInterfaceSample.EvolvedInterfaceImplementation;

// Adding Method to the IShippingMethod Interface
public interface IShippingMethod
{
    void AdvanceShippingMethod();
}

public class StandardShipping : IShippingMethod
{
    public int EstimatedDeliveryDays { get; private set; } = 5;

    public void AdvanceShippingMethod()
    {
        EstimatedDeliveryDays--;
    }
}

public class ExpressShipping : IShippingMethod
{
    public int EstimatedDeliveryDays { get; private set; } = 2;

    public void AdvanceShippingMethod()
    {
        EstimatedDeliveryDays--;
    }
}