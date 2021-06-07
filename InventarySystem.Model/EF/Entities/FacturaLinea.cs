using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace InventorySystem.Model.EF
{
    public partial class FacturaLinea
    {
        [Key]
        public Guid ID_FacturaLinea { get; set; }
        public Guid ID_Factura { get; set; }
        public Guid ID_Articulo { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        [Column(TypeName = "decimal(12, 2)")]
        public decimal Precio { get; set; }
        [Column(TypeName = "decimal(12, 2)")]
        public decimal Descuento { get; set; }
    }
}
