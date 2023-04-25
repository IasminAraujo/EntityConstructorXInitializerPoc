namespace EntityConstructorXInitializerPoc.Entities;

public abstract class EntityInitializerBase
{
    private static readonly Random Rng = new(80085); //para gerar ids que seriam gerados pelo banco
    protected EntityInitializerBase()
    {

    }
    public int Id { get; init; } =  Rng.Next();
    public required DateTime CreatedAt { get; init; } //obrigatório na inicialização (required) e não permite alteração (init)
    public DateTime? UpdateAt { get;  set; }
}
