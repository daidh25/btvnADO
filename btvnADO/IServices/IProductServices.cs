using btvnADO.DTO;
using EShop.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btvnADO.IServices
{
    public  interface IProductServices 
    {
        Task<List<Product>> GetProducts();
        Task<ProductInsertReturnData> Product_Insert(Product product);
    }
}
