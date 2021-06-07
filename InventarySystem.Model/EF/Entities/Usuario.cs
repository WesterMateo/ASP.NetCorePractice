using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

#nullable disable

namespace InventorySystem.Model.EF
{
    public partial class Usuario : IdentityUser
    {
        public Guid ID_Usuario {get; set;}
    }
}
