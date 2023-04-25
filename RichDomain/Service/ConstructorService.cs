using EntityConstructorXInitializerPoc.Entities;

namespace EntityConstructorXInitializerPoc.Service;

public static class ConstructorService
{
    public static readonly List<EntityConstructor> entityConstructors= new List<EntityConstructor>();
    public static EntityConstructor Insert(string propertyRequired)
    {
        var entity = new EntityConstructor(0, propertyRequired, string.Empty);
        //Não funciona devido ao modificador de acesso private do setter
        //var entity = new EntityConstructor() { MyPropertyRequired = propertyRequired};  
        entityConstructors.Add(entity);
        return entity;
    }

    public static EntityConstructor Update(int id, string propertyOptional)
    {       
        var entity = entityConstructors.Where(x=>x.Id ==id).FirstOrDefault();
        if (entity is not null)
            entity.UpdateMyPropertyOptional(propertyOptional);
        return entity;
    }
}
