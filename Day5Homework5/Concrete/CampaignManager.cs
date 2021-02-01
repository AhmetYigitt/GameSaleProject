using Day5Homework5.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Homework5
{
    public class CampaignManager : ICampaignService
    {
        public void Add()
        {
            Console.WriteLine("Kampanya Eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " İsimli Kampanya Silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " İsimli Kampanya Güncellendi");
        }
    }
}
