using Day5Homework5.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Homework5
{
    public class Operation:IOperation
    {

        IGamerService _gamerManager;

        public Operation(IGamerService gamerManager)
        {
            _gamerManager = gamerManager;
        }

        public void Myoperation(List<Gamer> gamers, bool temp)
        {

            bool Temp1 = true;
            bool Temp2 = true;

            while (Temp2 == true)
            {
                string TempName = Console.ReadLine();
                foreach (var tempGamer in gamers)
                {
                    if (tempGamer.FirstName == TempName)
                    {
                        if (temp==true)
                        {
                            _gamerManager.Delete(tempGamer);
                        }
                        else
                        {
                            _gamerManager.Update(tempGamer);
                        }
                        Temp1 = false; Temp2 = false;
                        break;
                    }
                }
                if (Temp1 == true)
                {
                    Console.Write("Hatalı Seçim Yaptınız Tekrar Deneyiniz: ");
                }
            }

        }
    }
}
