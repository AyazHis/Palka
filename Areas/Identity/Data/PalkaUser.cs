using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Palka.Areas.Identity.Data;

// Add profile data for application users by adding properties to the PalkaUser class
public class PalkaUser : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public Address? Address1 { get; set; }
    
    public class Address
    {   
       public int Id { get; set; }
       public string? Oblast { get; set; }
       public string? City { get; set; }
       public string? Street { get; set; }
       public string? House { get; set; }


    }
} 

