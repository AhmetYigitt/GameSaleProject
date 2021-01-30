using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Homework5
{
    class GamerManager : IGamerService
    {
        IControlService _controlService;

        public GamerManager(IControlService controlService)
        {
            _controlService = controlService;
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + "Sistemden Silinmiştir");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " Güncellendi");
        }

        void IGamerService.Add(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Eklendi!!!!\n");

            _controlService.GamerControl(gamer);
        }
    }
}
