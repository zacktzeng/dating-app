using System;

namespace API.Entities;

public class AppUser
{
    // The Id field doesn't need to be required 
    // because integer type is a primitive type, and
    // it's assigned a default value of 0.
    public int Id { get; set; }
    
    // The UserName field is required because the string type is a reference type.
    public required string UserName { get; set; }
}
