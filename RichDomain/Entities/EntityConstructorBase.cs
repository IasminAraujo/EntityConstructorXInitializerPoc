namespace EntityConstructorXInitializerPoc.Entities;
public abstract class EntityConstructorBase
{
    private static readonly Random Rng = new(80085); //para gerar ids que seriam gerados pelo banco

    protected EntityConstructorBase()
    {
        CreatedAt= DateTime.Now;
    }
    protected EntityConstructorBase(int id)
    {
        Id = id;
        UpdateAt = Id > 0 ? DateTime.Now : null;
    }
    public int Id { get; } = Rng.Next();

    public DateTime CreatedAt { get; protected set; }
    public DateTime? UpdateAt { get; protected set; }
}
