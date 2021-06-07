using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Model.MArticulo
{
    public interface IArticuloRepository
    {
        Task<List<EF.Articulo>> GetAllArticuloAsync();
        List<EF.Articulo> GetAllArticulo();
        List<EF.Articulo> GetAllArticuloByID(Guid ID_Articulo);
        bool SaveArticulo(EF.Articulo Articulo);
        bool RemoveArticulo(EF.Articulo Articulo);
        
    }
}
