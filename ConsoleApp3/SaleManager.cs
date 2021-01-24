using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class SaleManager : ISaleService
    {
        private ICampaignService _campaignService;

        public SaleManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        public void Sale(User user, Product product)
        {
            ICampaign campaign = _campaignService.GetCampaign(user);
            campaign.ShowOffer(user, product);
            Console.WriteLine($"{product.Name}, {user.UserName} tarafından {product.Price}TL karşılığında alındı");
        }
    }
}
