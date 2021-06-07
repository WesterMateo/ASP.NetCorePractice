using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Model.MFacturaLinea
{
    class FacturaLineaModel : BaseModel,
        IFacturaLineaRepository
    {        
        public List<EF.FacturaLinea> GetAllFacturaLinea()
        { 
           using(_db)
            {
                return _db.FacturaLinea.ToList();
            }
        }
        public List<EF.FacturaLinea> GetAllFacturaLineaByID(Guid ID_FacturaLinea)
        {
            using (_db)
            {
                return _db.FacturaLinea.Where(x => x.ID_FacturaLinea == ID_FacturaLinea).ToList();
            }
        }

        public bool SaveFacturaLinea(EF.FacturaLinea FacturaLinea)
        {
            using (_db)
            {
                //if (FacturaLinea.ID_FacturaLinea > 0)
                //{
                //    _db.Update(FacturaLinea).State = EntityState.Modified;
                //}
                //else
                //{
                //    _db.FacturaLinea.Add(FacturaLinea);
                //}
                return _db.SaveChanges() > 0;
            }
        }

        public bool RemoveFacturaLinea(EF.FacturaLinea FacturaLinea)
        {
            using(_db)
            {
                _db.FacturaLinea.Remove(FacturaLinea);
                return _db.SaveChanges() > 0;
            }
        }
    }
}
