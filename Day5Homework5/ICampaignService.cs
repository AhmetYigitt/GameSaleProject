using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Homework5
{
    interface ICampaignService
    {
        void Add();
        void Delete(Campaign campaign);
        void Update(Campaign campaign);

    }
}
