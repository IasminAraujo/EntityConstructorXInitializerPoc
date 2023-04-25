namespace EntityConstructorXInitializerPoc.Entities;

public sealed class EntityConstructor : EntityConstructorBase
{
    //modelo 1 => usa apenas 1 construtor e passa valores nulos para propriedades opcionais
    public EntityConstructor(int id,string myPropertyRequired, string myPropertyOptional):base(id)
    {
        UpdateMyPropertyRequired(myPropertyRequired);
        UpdateMyPropertyOptional(myPropertyOptional);
    }

    //modelo 2 => usa mais de um construtor, um para cada paradigma de ação
    //public EntityConstructor(string myPropertyRequired)
    //{
    //    UpdateMyPropertyRequired(myPropertyRequired);
    //}
    //public EntityConstructor(int id, string myPropertyRequired, string myPropertyOptional) : base(id)
    //{
    //    UpdateMyPropertyRequired(myPropertyRequired);
    //    UpdateMyPropertyOptional(myPropertyOptional);
    //}

    public string MyPropertyRequired { get; private set; }
    public string MyPropertyOptional { get; private set; }

    //método público para permitir atualização do atributo de acordo com as regras
    public void UpdateMyPropertyRequired(string propertyRequired) {
        /*validate property wich flunt,br */
        MyPropertyRequired = propertyRequired;
    }

    public void UpdateMyPropertyOptional(string propertyRequired)
    {
        /*validate property wich flunt,br */
        MyPropertyRequired = propertyRequired;
    }
}
