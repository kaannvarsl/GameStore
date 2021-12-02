// See https://aka.ms/new-console-template for more information

namespace GameStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.Id = 55;
            gamer1.NationalityId = "42426346464";
            gamer1.FirstName = "Kaan";
            gamer1.LastName = "Varışlı";

            GamerManager gamerManager = new GamerManager(new VerificationManager());

            gamerManager.add(gamer1);

           Game game1= new Game();
            game1.GameId = 43;
            game1.GameName = "Witcher 3 ";
            game1.GamePrice = 20;

            GameManager gameManager = new GameManager();

            gameManager.Add(game1);
      
             
            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 5;
            campaign1.CampaignName = "Christmas";
            campaign1.CampaignDiscount = 50;

            CampaignManager campaignManager = new CampaignManager();  
            
            campaignManager.Add(campaign1);


            IGameSaleService gameSaleService = new GameSaleManager();
            gameSaleService.Sale(gamer1, game1, campaign1);


        }
    }
}