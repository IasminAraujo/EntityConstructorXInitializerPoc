namespace EntityConstructorXInitializerPoc.Entities;

public sealed class EntityInitializer : EntityInitializerBase
{

    //[SetsRequiredMembers]
    //public EntityObjectInitializer(string myPropertyOpitional)
    //{
    //    MyPropertyOptional= myPropertyOpitional;
    //}

    private string _myPropertyRequired= string.Empty;
    private string _myPropertyOpitional = string.Empty;
    public required string MyPropertyRequired { get => _myPropertyRequired; set => UpdateMyPropertyRequired(value); }
    public string MyPropertyOptional { get => _myPropertyOpitional; set => UpdateMyPropertyOptional(value); }

    //método privado pois a propridade se valida.
    private void UpdateMyPropertyRequired(string property)
    {
        /*validate property wich flunt.br */
        _myPropertyRequired = property;
    }

    private void UpdateMyPropertyOptional(string property)
    {
        /*validate property wich flunt.br */
        _myPropertyOpitional = property;
    }

}
