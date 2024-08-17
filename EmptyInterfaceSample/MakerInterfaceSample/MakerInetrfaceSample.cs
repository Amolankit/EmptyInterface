namespace EmptyInterfaceSample.MakerInterfaceSample;

// Marker Interface to Identify Aggregate Roots
public interface IAggregateRoot { }

// Domain Models
public class Book : IAggregateRoot
{
    public int Id { get; set; }
    public string Title { get; set; }
    public List<BookRelease> Releases { get; set; }
}

public class BookRelease
{
    public int ReleaseId { get; set; }
    public DateTime ReleaseDate { get; set; }
}

// Repository Interface with Constraint
public interface IRepository<T> where T : IAggregateRoot
{
    T GetById(int id);
    void Save(T entity);
}

// Book Repository Implementation
public class BookRepository : IRepository<Book>
{
    // Methods to retrieve and save books
    public Book GetById(int id) => new Book { Id = id, Title = "Sample Book" };

    public void Save(Book entity) 
    {
        /* Save logic here */ 
    }
}
