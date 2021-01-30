using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Homework5
{
    interface IGameSaleService
    {
        void GameSale1(Gamer gamer , Game game, Campaign campaign);
        void GameSale2(Gamer gamer, Game game);
    }
}
