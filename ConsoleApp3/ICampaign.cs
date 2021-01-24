using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public interface ICampaign
    {
        string CampaignName { get; set; }
        decimal DiscountRatio { get; set; }
        void ShowOffer(User user, Product product);
    }
}
