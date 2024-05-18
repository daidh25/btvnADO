using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btvnADO.DTO
{
    public class ReturnData
    {
        public int ReturnCode { get; set; }
        public string ReturnMsg { get; set; }
    }
    public class ProductInsertReturnData : ReturnData 
    { 
        public Product product { get; set; }
    }
}
