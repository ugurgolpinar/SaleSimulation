using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserService userManager = new UserManager();
            ICampaignService campaignService = new CampaignManager();
            ISaleService saleService = new SaleManager(campaignService);
            
            EDevletService service = new EDevletService();
            User user1 = new User
            {
                Id = 1,
                TcNo = "11111111111",
                UserName = "ugurgolpinar",
                Password = "123456",
                FirstName = "Uğur",
                LastName = "Gölpınar",
                BirthDate = new DateTime(1996, 12, 11)
            };

            userManager.Add(user1, service);

            Product product1 = new Product
            {
                Id = 1,
                CategoryId = 1,
                Name = "Cyberpunk 2077",
                Price = 250,
                UnitInStock = 10
            };

            saleService.Sale(user1, product1);
        }
    }
}
