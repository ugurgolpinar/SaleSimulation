using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class NewUserCampaignManager : ICampaign
    {
        public string CampaignName { get; set; } = "Hoşgeldin Kampanyası";
        public decimal DiscountRatio { get; set; } = 0.5M;
        public void ShowOffer(User user, Product product)
        {
            decimal mainPrice = product.Price;
            product.Price = product.Price * DiscountRatio;
            Console.WriteLine($"{product.Name}: {mainPrice}TL. {CampaignName} ile size özel {product.Price}TL");
        }
    }
}
