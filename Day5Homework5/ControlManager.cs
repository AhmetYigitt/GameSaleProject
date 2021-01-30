using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Homework5
{
    class ControlManager : IControlService
    {
        public void GamerControl(Gamer gamer)
        {
            Console.WriteLine("Adı: " + gamer.FirstName);
            Console.WriteLine("Soyadı: " + gamer.LastName);
            Console.WriteLine("Doğum Tarihi: " + gamer.DateOfBirth);
            Console.WriteLine("Tc Kimlik No: " + gamer.NationalityId);
            Console.WriteLine("Yukarıda Bilgileri Yazılı Olan Kişi E-Devlet Tarafından Kontrol Edilmiştir");
        }
    }
}
