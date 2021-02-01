using Day5Homework5.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Homework5
{
    public class ListManager : IListService
    {
        public void CampaignList(List<Campaign> campaigns)
        {
            int i = 1;
            foreach (var campaign in campaigns)
            {
                Console.WriteLine(i + "-" + campaign.CampaignName);
                i++;
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
