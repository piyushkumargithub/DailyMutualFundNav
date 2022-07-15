using DailyMutualFundNAV.Database;
using DailyMutualFundNAV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyMutualFundNAV.Repository
{
    public class MutualFundRepository : IMutualFundRepository
    {
        public MutualFundDetails GetMutualFundNav(string fundName)
        {
            var fund = MutualFundsDb.fundList.FirstOrDefault(s => s.MutualFundName.ToLower() == fundName.ToLower());
            if (fund == null)
            {
                return null;
            }
            return fund;
        }
    }
}
