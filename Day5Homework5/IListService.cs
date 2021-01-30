using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Homework5
{
    interface IListService
    {
        void GamerList(List<Gamer> gamers);
        void GameList(List<Game> games);
        void CampaignList(List<Campaign> campaigns);
    }
}
