﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btvnADO.DTO
{
    public class Product
    {
       public int ProductID { get; set; }
       public string ProductName {  get; set; }
       public int CategoryID { get; set; }
       public DateTime DateOfManufacture {  get; set; }
    }
}
