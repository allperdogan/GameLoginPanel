using OyunGirisOdev.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunGirisOdev.Entities
{
    public class Campaign : IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public string CampaignDescription { get; set; }
        public DateTime DateOfCampaign { get; set; }
        public double Discount { get; set; }
    }
}
