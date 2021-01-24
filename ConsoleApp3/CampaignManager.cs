using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class CampaignManager : ICampaignService
    {
        public void Add(ICampaign campaign)
        {
            Console.WriteLine("Yeni kampanya eklendi");
        }

        public void Delete(ICampaign campaign)
        {
            Console.WriteLine("Kampanya silindi");
        }

        public ICampaign GetCampaign(User user)
        {
            Console.WriteLine($"{user.UserName} kullanıcısı aramıza yeni katıldı");
            return new NewUserCampaignManager();
        }

        public void Show(ICampaign campaign, User user, Product product)
        {
            campaign.ShowOffer(user, product);
        }

        public void Update(ICampaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi");
        }


    }
}
