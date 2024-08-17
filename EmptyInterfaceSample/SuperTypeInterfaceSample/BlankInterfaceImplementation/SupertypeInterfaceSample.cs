namespace EmptyInterfaceSample.SuperTypeInterfaceSample.BlankInterfaceImplementation;

// Supertype Interface for Shipping Methods
public interface IShippingMethod { }

// Concrete Shipping Method Implementations
public class StandardShipping : IShippingMethod
{
    public int EstimatedDeliveryDays { get; set; } = 5;
}

public class ExpressShipping : IShippingMethod
{
    public int EstimatedDeliveryDays { get; init; } = 2;
}

// Shipment that uses Shipping Methods
public class Shipment
{
    public IShippingMethod ShippingMethod { get; init; } = null!;

    public void PrintShippingDetails()
    {
        switch (ShippingMethod)
        {
            case StandardShipping standardShipping:
                Console.WriteLine($"Standard Shipping - Estimated Delivery: {standardShipping.EstimatedDeliveryDays} days");
                break;
            case ExpressShipping expressShipping:
                Console.WriteLine($"Express Shipping - Estimated Delivery: {expressShipping.EstimatedDeliveryDays} days");
                break;
        }
    }
}