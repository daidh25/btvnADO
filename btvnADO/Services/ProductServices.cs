using btvnADO.DBContext;
using btvnADO.DTO;
using btvnADO.IServices;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace btvnADO.Services
{
    public class ProductServices : IProductServices
    {
        private  EProductDbContext _eProductDbContext;
        private  ILogger<ProductServices> _logger;
       
        public ProductServices(EProductDbContext eProductDbContext, ILogger<ProductServices> logger)
        {
            _eProductDbContext = eProductDbContext;
            _logger = logger;
        }

        public ProductServices()
        {
           
        }

        public async Task<ProductInsertReturnData> Product_Insert(Product product)
        {
            var returnData = new ProductInsertReturnData();
            try
            {
                if (product == null || string.IsNullOrEmpty(product.ProductName))
                {
                    returnData.ReturnCode = (int)EShop.Common.Enum_ReturnCode.DataInValid;
                    returnData.ReturnMsg = "Dữ liệu đầu vào không hợp lệ";
                    return returnData;
                }
                await _eProductDbContext.product.AddAsync(product);
                var result = await _eProductDbContext.SaveChangesAsync();
                returnData.ReturnCode = (int)EShop.Common.Enum_ReturnCode.Success;
                returnData.ReturnMsg = "Thêm dữ liệu thành công";
            }
            catch (Exception ex)
            {
               
                _logger.LogError(ex, "Đã xảy ra lỗi khi thêm sản phẩm");
                returnData.ReturnCode = (int)EShop.Common.Enum_ReturnCode.DataInValid;
                returnData.ReturnMsg = "Đã xảy ra lỗi khi xử lý yêu cầu của bạn";
            }

            return returnData;
        }

        public async Task<List<Product>> GetProducts()
        {
            try
            {
                return await _eProductDbContext.product.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Đã xảy ra lỗi khi lấy danh sách sản phẩm");
                throw;
            }
        }
    }
}
