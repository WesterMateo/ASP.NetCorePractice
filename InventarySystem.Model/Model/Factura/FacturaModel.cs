using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Model.MFactura
{
    class FacturaModel : BaseModel,
        IFacturaRepository
    {        
        public List<EF.Factura> GetAllFactura()
        { 
           using(_db)
            {
                return _db.Factura.ToList();
            }
        }
        public List<EF.Factura> GetAllFacturaByID(Guid ID_Factura)
        {
            using (_db)
            {
                return _db.Factura.Where(x => x.ID_Factura == ID_Factura).ToList();
            }
        }

        public bool SaveFactura(EF.Factura Factura)
        {
            using (_db)
            {
                //if (Factura.ID_Factura > 0)
                //{
                //    _db.Update(Factura).State = EntityState.Modified;
                //}
                //else
                //{
                //    _db.Factura.Add(Factura);
                //}
                return _db.SaveChanges() > 0;
            }
        }

        public bool RemoveFactura(EF.Factura Factura)
        {
            using(_db)
            {
                _db.Factura.Remove(Factura);
                return _db.SaveChanges() > 0;
            }
        }
    }
}
