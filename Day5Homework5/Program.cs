using Day5Homework5.Abstract;
using System;
using System.Collections.Generic;

namespace Day5Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            IGameSaleService gameSaleManager = new GameSaleManager();

            IControlService controlManager = new ControlManager();

            IGamerService gamerManager = new GamerManager(controlManager);

            IListService listManager = new ListManager();

            ICampaignService campaignManager = new CampaignManager();

            Operation operation = new Operation(gamerManager);

            Gamer gamer1 = new Gamer {Id=2, FirstName = "Yiğit", LastName = "Arıtürk", DateOfBirth = "21.06.1999", NationalityId = "12345678910" };
            Gamer gamer2 = new Gamer { Id = 3, FirstName = "Anday", LastName = "Aktaş", DateOfBirth = "29.10.1999", NationalityId = "12345678910" };
            Gamer gamer3 = new Gamer { Id =4, FirstName = "Tunahan", LastName = "Kaya", DateOfBirth = "05.12.1999", NationalityId = "12345678910" };
            Gamer gamer4 = new Gamer { Id = 5, FirstName = "Yağmur", LastName = "Ekşi", DateOfBirth = "19.05.1999", NationalityId = "12345678910" };

            Game game1= new Game { Id = 1, GameName = "Gta5", ReleaseYear = "2013" };
            Game game2 = new Game { Id = 2, GameName = "CSGO", ReleaseYear = "2012" };
            Game game3 = new Game { Id = 3, GameName = "Cyberpunk 2077", ReleaseYear = "2020" };
            Game game4 = new Game { Id = 4, GameName = "Age Of Empries", ReleaseYear = "2005" };

            Campaign campaign1 = new Campaign { Id = 1, CampaignName = "Öğrenci Kampanyası" };
            Campaign campaign2 = new Campaign { Id = 2, CampaignName = "Yeni Yıl Kampanyası" };


            List<Gamer> gamers = new List<Gamer> { gamer1, gamer2, gamer3, gamer4 };
            List<Game> games = new List<Game> { game1, game2, game3, game4 };
            List<Campaign> campaigns = new List<Campaign> { campaign1, campaign2 };

            



            bool temp = true;
            while (temp)
            {
                Console.WriteLine("\n----------MENU----------");
                Console.WriteLine("1)Oyuncu Ekleme\n2)Oyuncu Silme\n3)Oyuncu Güncelleme\n4)Kayıtlı Oyunucuları Görüntüleme\n5)Oyun Satın Alma\n" +
                    "6)Kampanyaları Listeleme\n7)Kampanya Ekleme\n8)Kampanya Silme\n9)Kampanya Güncelleme\n10)Sistemden Çıkış");
                Console.Write("Seçiminiz: ");

                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                switch (x)
                {
                    case 1:
                        Gamer gamer = new Gamer();
                        gamer.Id = 1;
                        Console.Write("Adı: ");
                        gamer.FirstName = Console.ReadLine();
                        Console.Write("Soyadı: ");
                        gamer.LastName = Console.ReadLine();
                        Console.Write("Doğum Tarihi: ");
                        gamer.DateOfBirth = Console.ReadLine();
                        Console.Write("Tc Kimlik No: ");
                        gamer.NationalityId = Console.ReadLine();

                        gamerManager.Add(gamer);
                        
                        break;
                    case 2:

                        listManager.GamerList(gamers);
                        Console.Write("\nSilenecek Oyunucunun İsmini Giriniz: ");

                        operation.Myoperation(gamers, true);
                        break;
                    case 3:
                        listManager.GamerList(gamers);
                        Console.Write("\nGüncellenecek Oyunucunun İsmini Giriniz: ");

                        operation.Myoperation(gamers, false);
                        break;
                    case 4:
                        listManager.GamerList(gamers);
                        break;
                    case 5:
                        listManager.GameList(games);
                        Console.Write("Satın Almak İstediğiniz Oyunun İsmini Giriniz: ");
                        string WantedGame = Console.ReadLine();
                        string Name;

                        foreach (var game in games)
                        {
                            if (WantedGame == game.GameName)
                            {
                                Console.WriteLine("");
                                listManager.CampaignList(campaigns);
                                Console.WriteLine("0-Kampanya Uygulamak İstemiyorum");
                                Console.Write("Uygulamak İstediğiniz Kampanyayı Seçiniz: ");
                                int tempKampanya = int.Parse(Console.ReadLine());

                                foreach (var campaign in campaigns)
                                {
                                    if (tempKampanya == campaign.Id)
                                    {
                                        Console.WriteLine("İsminizi Giriniz");
                                        Name = Console.ReadLine();
                                        bool temp1 = true;
                                        
                                        foreach (var tempGamer in gamers)
                                        {
                                            if (Name == tempGamer.FirstName)
                                            {
                                                gameSaleManager.GameSale1(tempGamer, game, campaign);
                                                
                                                temp1 = false;
                                                break;
                                            }

                                        }
                                        if (temp1==true)
                                        {
                                            Console.WriteLine("İsminiz Sistemde Kayıtlı Değil");
                                        }
                                        

                                    }
                                    if (tempKampanya == 0)
                                    {
                                        bool temp2 = true;
                                        Console.WriteLine("İsminizi Giriniz");
                                        Name = Console.ReadLine();
                                        foreach (var tempGamer in gamers)
                                        {
                                            if (Name == tempGamer.FirstName)
                                            {
                                                gameSaleManager.GameSale2(tempGamer, game);
                                                temp2 = false;
                                                break;

                                            }

                                        }
                                        if (temp2 == true)
                                        {
                                            Console.WriteLine("İsminiz Sistemde Kayıtlı Değil");
                                        }
                                        break;
                                    }
                                }



                            }

                        }

                        break;
                    case 6:
                        listManager.CampaignList(campaigns);
                        break;
                    case 7:
                        campaignManager.Add();
                        break;
                    case 8:
                        listManager.CampaignList(campaigns);
                        Console.Write("Silmek İstediğiniz Kampanya Numarasını Griniz: ");
                        int tempNumber = int.Parse(Console.ReadLine());
                        foreach (var campaign in campaigns)
                        {
                            if (tempNumber == campaign.Id)
                            {
                                campaignManager.Delete(campaign);
                                break;
                            }
                        }
                        break;
                    case 9:
                        listManager.CampaignList(campaigns);
                        Console.Write("Güncellemek İstediğiniz Kampanya Numarasını Griniz: ");
                        tempNumber = int.Parse(Console.ReadLine());
                        foreach (var campaign in campaigns)
                        {
                            if (tempNumber == campaign.Id)
                            {
                                campaignManager.Update(campaign);
                                break;
                            }
                        }
                        break;
                    case 10:
                        temp = false;
                        
                        break;

                    default:
                        Console.WriteLine("Hatalı Seçim Yaptınız");
                        break;
                }
            }
        }
    }
}
