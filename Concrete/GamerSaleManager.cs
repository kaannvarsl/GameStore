using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
     class GameSaleManager:IGameSaleService
    {
        public void Sale(Gamer gamer,Game game, Campaign campaign)
        {
            double newPrice = game.GamePrice-(game.GamePrice + (campaign.CampaignDiscount / 80));

            Console.WriteLine(gamer.FirstName + "oyuncusu" + game.GameName + "satın aldı!");

            Console.WriteLine("Oyunun fiyatı" + game.GamePrice + "tl 'dir");
            Console.WriteLine(campaign.CampaignName + "Kampanyası" +"ve indirim tutarı % " + campaign.CampaignDiscount + "'dır.");

            Console.WriteLine("Oyunun indirimli fiyatı " + newPrice + "'dır.");

            Console.WriteLine("************************************************************");
        
     
        }
    }
}
