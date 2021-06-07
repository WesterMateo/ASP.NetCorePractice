using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Model.MFactura
{
    interface IFacturaRepository
    {
        List<EF.Factura> GetAllFactura();
        List<EF.Factura> GetAllFacturaByID(Guid ID_Factura);
        bool SaveFactura(EF.Factura Factura);
        bool RemoveFactura(EF.Factura Factura);
        
    }
}
