using BileshwarOilMill.Models;

namespace BileshwarOilMill.Helper
{
    public class ProductHelper
    {
        public static ProductDetailsModel GetProductDetails(int productId)
        {
            if (productId == 1)
            {
                return new ProductDetailsModel()
                {
                    Category= "Edible Oil",
                    Description="100% Pure and Natural edible oil for daily use",
                    Id=productId,
                    Name="Peanut Oil",
                    Price=2800
                };
            }
            else
            {
                return new ProductDetailsModel()
                {
                    Category = "Default",
                    Description = "Default",
                    Id = productId,
                    Name = "Default",
                    Price = 0
                };
            }
        }
    }
}
