using OyunGirisOdev.Abstract;
using OyunGirisOdev.Adapters;
using OyunGirisOdev.Concrete;
using OyunGirisOdev.Entities;

namespace OyunGirisOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.FirstName = "Alper";
            gamer1.LastName = "Doğan";
            gamer1.NationalityId = "60886175292";
            gamer1.YearOfBirth = 1999;
            gamer1.Nickname = "doalper";

            Campaign campaign1 = new Campaign();
            campaign1.CampaignName = "Kampanya %50";
            campaign1.CampaignDescription = "En iyi kampanya";
            campaign1.Discount = 0.5;
            campaign1.DateOfCampaign = new DateTime(2023, 1, 27);

            Campaign campaign2 = new Campaign();
            campaign2.CampaignName = "Kampanya %75";
            campaign2.CampaignDescription = "En iyi kampanya";
            campaign2.Discount = 0.75;
            campaign2.DateOfCampaign = new DateTime(2023, 1, 27);

            Product product1 = new Product();
            product1.ProductName = "FIFA 23";
            product1.ProductPrice = 100;
            
            IGamerCheckService gamerCheckService = new MernisServiceAdapter();

            IGamerService gamerManager = new GamerManager(gamerCheckService);
            gamerManager.Add(gamer1);

            ICampaignService campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);

            ISaleService saleManager = new SaleManager();
            saleManager.Sale(product1, gamer1);
            saleManager.Sale(product1, gamer1, campaign1);
            saleManager.Sale(product1, gamer1, campaign2);

        }
    }
}