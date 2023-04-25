using EntityConstructorXInitializerPoc.Service;

var objectInitializer1 = InitializerService.Insert("propertyInicializer1");

InitializerService.Update(objectInitializer1.Id, "propertyInicializer1Update");

var objectConstructor1 = ConstructorService.Insert("propertyConstructor1");

ConstructorService.Update(objectInitializer1.Id, "propertyConstructorUpdate");
