using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Model.MArticulo
{
    public class ArticuloModel : BaseModel,
        IArticuloRepository
    {        
        public Task<List<EF.Articulo>> GetAllArticuloAsync()
        { 
           using(_db)
            {
                return _db.Articulo.ToListAsync();
            }
        }
        public List<EF.Articulo> GetAllArticulo()
        {
            using (_db)
            {
                return _db.Articulo.ToList();
            }
        }
        public List<EF.Articulo> GetAllArticuloByID(Guid ID_Articulo)
        {
            using (_db)
            {
                return _db.Articulo.Where(x => x.ID_Articulo == ID_Articulo).ToList();
            }
        }

        public bool SaveArticulo(EF.Articulo Articulo)
        {
            using (_db)
            {
                //if (Articulo.ID_Articulo > 0)
                //{
                //    _db.Update(Articulo).State = EntityState.Modified;
                //}
                //else
                //{
                //    _db.Articulo.Add(Articulo);
                //}
                return _db.SaveChanges() > 0;
            }
        }

        public bool RemoveArticulo(EF.Articulo Articulo)
        {
            using(_db)
            {
                _db.Articulo.Remove(Articulo);
                return _db.SaveChanges() > 0;
            }
        }
    }
}
