using WebApplication2.Models;
using Microsoft.AspNetCore.Identity;

namespace WebApplication2;



public class ApplicationUser : IdentityUser
{
    // Kullanıcıya ait ek özellikler ekleyebilirsiniz
    public string FullName { get; set; }
}

public class ApplicationRole : IdentityRole
{
    // Role özel ek alanlar ekleyebilirsiniz
}
