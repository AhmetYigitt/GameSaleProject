using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Homework5
{
    internal class ListManager : IListService
    {
        public void CampaignList(List<Campaign> campaigns)
        {
            foreach (var campaign in campaigns)
            {
                Console.WriteLine(campaign.CampaignName);
            }
        }

        public void GameList(List<Game> games)
        {
            foreach (var game in games)
            {
                Console.WriteLine("Oyun Adı: " + game.GameName + "   Çıkış Yılı: " + game.ReleaseYear);
            }
        }

        public void GamerList(List<Gamer> gamers)
        {
            foreach (var gamer in gamers)
            {
                Console.WriteLine("Adı: " + gamer.FirstName);
                Console.WriteLine("Soyadı: " + gamer.LastName);
                Console.WriteLine("Doğum Tarihi: " + gamer.DateOfBirth);
                Console.WriteLine("Tc Kimlik No: " + gamer.NationalityId + "\n");

            }
        }
    }
}
