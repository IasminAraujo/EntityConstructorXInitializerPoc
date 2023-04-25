using EntityConstructorXInitializerPoc.Entities;

namespace EntityConstructorXInitializerPoc.Service;

public static class InitializerService
{
    public static readonly List<EntityInitializer> entityInitializers = new List<EntityInitializer>();
    public static EntityInitializer Insert(string propertyRequired)
    {
        var entity = new EntityInitializer() { MyPropertyRequired = propertyRequired, CreatedAt=DateTime.Now};
        //funciona se houver um construtor com a anotação SetsRequiredMembers que anula o required do atribudo e faz valer o required do construtor.
        //var entity = new EntityInitializer(propertyRequired); 
        entityInitializers.Add(entity);
        return entity;
    }

    public static EntityInitializer Update(int id, string propertyOptional)
    {
        var entity = entityInitializers.Where(x => x.Id == id).FirstOrDefault();
        if (entity is not null)
        {
            entityInitializers.Remove(entity);
            entity.MyPropertyOptional = propertyOptional;
            entity.UpdateAt= DateTime.Now;
            //modificador init não permite
            //entity.CreatedAt = DateTime.Now;
            entityInitializers.Add(entity);
        }
       
        return entity;
    }
}
