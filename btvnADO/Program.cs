using btvnADO.DBContext;
using btvnADO.DTO;
using btvnADO.IServices;
using btvnADO.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace btvnADO
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            
            var productServices = new ProductServices();

            if (productServices != null)
            {
                Console.WriteLine("Nhập ProductName: ");
                string productName = Console.ReadLine();

                if (!string.IsNullOrEmpty(productName))
                {
                    var product = new Product
                    {
                        ProductID = 1, 
                        ProductName = productName,
                        CategoryID = 1,
                        DateOfManufacture = DateTime.Now,
                    };

                    var result = await productServices.Product_Insert(product);

                    if (result.ReturnCode < 0)
                    {
                        Console.WriteLine("Thêm lỗi với lý do: {0}", result.ReturnMsg);
                    }
                    else
                    {
                        var insertedProduct = result.product;
                        Console.WriteLine("Sản phẩm được thêm thành công: {0}", insertedProduct.ProductName);
                    }
                }
                else
                {
                    Console.WriteLine("Tên sản phẩm không được để trống");
                }
            }
            else
            {
                Console.WriteLine("Không thể khởi tạo dịch vụ ProductServices");
            }
        }
}
}
