using DailyMutualFundNAV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyMutualFundNAV.Repository
{
    public interface IMutualFundRepository
    {
        MutualFundDetails GetMutualFundNav(string fundName);
    }
}
