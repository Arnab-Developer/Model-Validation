# ASP.NET MVC Model validation

A demo for model validation in ASP.NET MVC. The validation attributes has been used in the 
`ModelValidation.Models.Registration` model class. 

```csharp
[Required(ErrorMessage = "Please enter name.")]
[StringLength(20, ErrorMessage = "Name must be 20 char max.")]
public string Name { get; set; }
```

When this class has been used in the controller and view then automatically ASP.NET did validation
with it. We need to check if the model is valid in the `ModelValidation.Controllers.RegistrationController` 
controller at the time of saving data in the database.

```csharp
if (ModelState.IsValid)
{
}
```
