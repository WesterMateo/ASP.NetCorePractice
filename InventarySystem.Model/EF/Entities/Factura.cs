using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace InventorySystem.Model.EF
{
    public partial class Factura
    {        
        [Key]
        public Guid ID_Factura { get; set; }
        public Guid ID_Usuario { get; set; }
        public string Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public bool Despachado { get; set; }
        [Column(TypeName = "decimal(12, 2)")]
        public decimal ImporteFactura { get; set; }
        [Column(TypeName = "decimal(12, 2)")]
        public decimal Cambio { get; set; }
    }
}
