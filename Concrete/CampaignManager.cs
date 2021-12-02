using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "Kampanya eklendi" + "%" + campaign.CampaignDiscount + "indiriminiz hazır");
            Console.WriteLine("----------------------------------------------------------------------------------------------------");

        }
        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "kampanya silindi");

        }
         public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "kampanya güncellendi");
            Console.WriteLine("Mevcut indirim " + campaign.CampaignDiscount);
        }
    
    }   
}