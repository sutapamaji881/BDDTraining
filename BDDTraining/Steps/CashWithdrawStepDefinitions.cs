using TechTalk.SpecFlow;
using System;
using NUnit.Framework;
using BDDTraining.ModelClass;
using BDDTraining.HelperClass;
using BDDTraining.Main.ModelClass;

namespace BDDTraining.Steps
{
    [Binding]
    public class CashWithdrawStepDefinitions
    {
        private DomainHelper domainHelper;

        public CashWithdrawStepDefinitions()
        {   
            domainHelper = new DomainHelper();
        }

        [Given(@"I have a balance of \$(.*) in my account")]
        public void GivenIHaveABalanceOfInMyAccount(int amount)
        {
            domainHelper.GetAccount().deposite(amount);
            Assert.AreEqual(amount, domainHelper.GetAccount().getBalance());
        }

        [When(@"I request \$(.*)")]
        public void WhenIRequest(int requestAmount)
        {
            domainHelper.GetTeller().withdrawCash(domainHelper.GetAccount(), requestAmount);
        }

        [Then(@"\$(.*) should be dispensed")]
        public void ThenShouldBeDispensed(int dispensedAmount)
        {
            Assert.AreEqual(dispensedAmount, domainHelper.GetCashSlot().GetContents());
        }

    }

   
}
