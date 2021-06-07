using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace InventorySystem.Model.EF
{
    public partial class Articulo
    {
        //public Articulo()
        //{
        //    FacturaLineas = new HashSet<FacturaLinea>();
        //}
        [Key]
        public Guid ID_Articulo { get; set; }
        public Guid ID_Categoria { get; set; }
        public string Descripcion { get; set; }
        [Column(TypeName = "decimal(12, 2)")]
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public bool Activo { get; set; }

        //public virtual ICollection<FacturaLinea> FacturaLineas { get; set; }
    }
}
