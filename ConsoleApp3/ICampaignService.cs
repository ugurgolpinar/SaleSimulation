using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public interface ICampaignService
    {
        void Add(ICampaign campaign);
        void Update(ICampaign campaign);
        void Delete(ICampaign campaign);
        ICampaign GetCampaign(User user);
        void Show(ICampaign campaign, User user, Product product);
    }
}
