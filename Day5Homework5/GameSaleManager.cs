using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Homework5
{
    class GameSaleManager : IGameSaleService
    {
        public void GameSale1(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + " " + campaign.CampaignName + "Kampanyası Kullanarak "
                + game.GameName + " " + "Satın Aldı");
        }

        public void GameSale2(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName + " " + game.GameName + " " + "Satın Aldı");
        }
    }
}
