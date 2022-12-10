using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Travel_Agency_MVC.Models
{
    public class DefaultUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName ="navchar(100)")]
        public string FirstName { get; set; }
        [PersonalData]
        [Column(TypeName = "navchar(100)")]
        public string LastName { get; set; }
    }
}
