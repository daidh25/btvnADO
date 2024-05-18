using btvnADO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btvnADO.IServices
{
    public interface IWarehouse
    {
        Task<List<Warehouse>> GetWarehouses();
    }
}
