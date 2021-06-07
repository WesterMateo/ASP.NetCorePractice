using InventorySystem.Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Model
{
    public class BaseModel
    {
        protected OmegaTecContext _db;

        public BaseModel()
        {
            _db = new OmegaTecContext();
        }
        private void Instanciar()
        {
            _db = new OmegaTecContext();
        }
    }
}
