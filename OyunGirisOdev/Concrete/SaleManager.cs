using OyunGirisOdev.Abstract;
using OyunGirisOdev.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunGirisOdev.Concrete
{
    internal class SaleManager : ISaleService
    {
        private ICampaignService _campaignService;

        public void Sale(Product product, Gamer gamer, Campaign campaign = null)
        {
            if (campaign != null)
            {
                Console.WriteLine(product.ProductName + " : " + product.ProductPrice + " ürünü " + gamer.Nickname + " adlı kullanıcıya " + campaign.CampaignName +
               " kampanyası ile " + (product.ProductPrice - (product.ProductPrice) * campaign.Discount) + " TL' ye satılmıştır.");
            }
            else
            {
                Console.WriteLine(product.ProductName + " : " + product.ProductPrice + " ürünü " + gamer.Nickname + " adlı kullanıcıya "  +
               +(product.ProductPrice) + " TL' ye satılmıştır.");
            }
        }
    }
}
