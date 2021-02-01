using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Homework5.Abstract
{
    public interface ICampaignService
    {
        void Add();
        void Delete(Campaign campaign);
        void Update(Campaign campaign);

    }
}
