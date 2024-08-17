namespace EmptyInterfaceSample.MakerInterfaceSample;

// Marker Interface to Identify Aggregate Roots
public interface IAggregateRoot { }

// Domain Models
public class Order : IAggregateRoot
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; } = null!;
    public List<Shipment> Shipments { get; set; } = null!;
}

public class Shipment
{
    public int ShipmentId { get; set; }
    public DateTime ShipmentDate { get; set; }
}

// Repository Interface with Constraint
public interface IRepository<T> where T : IAggregateRoot
{
    T GetById(int id);
    void Save(T entity);
}

// Order Repository Implementation
public class OrderRepository : IRepository<Order>
{

    // Methods to retrieve and save orders
    public Order GetById(int id) => new Order { OrderId = id, CustomerName = "John Doe" };

    public void Save(Order entity)
    {
         /* Save logic here */
    }
}