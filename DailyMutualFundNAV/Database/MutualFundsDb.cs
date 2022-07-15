using DailyMutualFundNAV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyMutualFundNAV.Database
{
    public class MutualFundsDb
    {
        public static List<MutualFundDetails> fundList { get; set; } = new List<MutualFundDetails>() {
        new MutualFundDetails()
            {
                MutualFundId = 1,
                MutualFundName = "Quant Small Cap Fund Direct Plan-Growth",
                MutualFundValue= 126
            },
        new MutualFundDetails()
            {
                MutualFundId = 2,
                MutualFundName = "Axis Small Cap Fund Direct-Growth",
                MutualFundValue= 60
            },
        new MutualFundDetails()
            {
                MutualFundId = 3,
                MutualFundName = "Kotak Small Cap Fund Direct-Growth",
                MutualFundValue= 163
            },
        new MutualFundDetails()
            {
                MutualFundId = 4,
                MutualFundName = "ICICI Small Cap Fund  Direct-Growth",
                MutualFundValue= 50
            },
        new MutualFundDetails()
            {
                MutualFundId = 5,
                MutualFundName = "Quant Mid Cap Fund Direct-Growth",
                MutualFundValue= 112
            },
        new MutualFundDetails()
            {
                MutualFundId = 6,
                MutualFundName = "BNP Paribas MidCap Direct-Growth",
                MutualFundValue= 61
            },
        new MutualFundDetails()
            {
                MutualFundId = 7,
                MutualFundName = "Tata MidCap Direct Plan-Growth",
                MutualFundValue= 242
            },
        new MutualFundDetails()
            {
                MutualFundId = 8,
                MutualFundName = "Edelweiss Mid Cap Direct Plan-Growth",
                MutualFundValue= 51
            },
        new MutualFundDetails()
            {
                MutualFundId = 9,
                MutualFundName = "SBI Large Cap Fund Direct Plan-Growth",
                MutualFundValue= 351
            },
        new MutualFundDetails()
            {
                MutualFundId = 10,
                MutualFundName = "HDFC Small Cap Fund Direct-Growth",
                MutualFundValue= 75
            },
        new MutualFundDetails()
            {
                MutualFundId =11,
                MutualFundName = "Tata Large Cap Fund Direct Plan-Growth",
                MutualFundValue= 331
            },
        new MutualFundDetails()
            {
                MutualFundId = 12,
                MutualFundName = "Nippon India Value Direct-Growth",
                MutualFundValue= 120
            }
        };
    }
}
