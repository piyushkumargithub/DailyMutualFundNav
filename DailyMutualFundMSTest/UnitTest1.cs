using DailyMutualFundNAV.Controllers;
using DailyMutualFundNAV.Model;
using DailyMutualFundNAV.Repository;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace DailyMutualFundMSTest
{
    public class Tests
    {
        List<MutualFundDetails> mutualFunds = new List<MutualFundDetails>();
        MutualFundNavController mutualfundController;
        
        private readonly Mock<IMutualFundRepository> mockRepository = new Mock<IMutualFundRepository>();
        [SetUp]
        public void Setup()
        {
            mutualfundController = new MutualFundNavController(mockRepository.Object);
            mutualFunds = new List<MutualFundDetails>()
            {
                new MutualFundDetails{ MutualFundId=45,MutualFundName="AxisBankDummy",MutualFundValue=(int)145.23},
                new MutualFundDetails{ MutualFundId=65,MutualFundName="KotakBankDummy",MutualFundValue=(int)145.23}
            };
           

            mockRepository.Setup(x => x.GetMutualFundNav(It.IsAny<string>())).Returns((string s) => mutualFunds.FirstOrDefault(
                x => x.MutualFundName.Equals(s)));

        }

        [Test]
        public void GetMutualFundDetailsByNameControllerPass()
        {
            var fund = mutualfundController.GetDailyMutualFundNav("AxisBankDummy");
            ObjectResult result = fund as ObjectResult;
            Assert.That(result.StatusCode, Is.EqualTo(200));
        }
       
        
        

    }
}