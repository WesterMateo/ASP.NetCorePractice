using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Model.MFacturaLinea
{
    interface IFacturaLineaRepository
    {
        List<EF.FacturaLinea> GetAllFacturaLinea();
        List<EF.FacturaLinea> GetAllFacturaLineaByID(Guid ID_FacturaLinea);
        bool SaveFacturaLinea(EF.FacturaLinea FacturaLinea);
        bool RemoveFacturaLinea(EF.FacturaLinea FacturaLinea);
        
    }
}
