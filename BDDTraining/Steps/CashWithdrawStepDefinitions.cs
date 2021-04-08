using TechTalk.SpecFlow;
using System;
using NUnit.Framework;
using BDDTraining.ModelClass;
using BDDTraining.HelperClass;

namespace BDDTraining.Steps
{
    [Binding]
    public sealed class CashWithdrawStepDefinitions
    {
        private Account account;
        private DomainHelper domainHelper;

        public CashWithdrawStepDefinitions()
        {
            domainHelper = new DomainHelper();
        }

        [Given(@"I have a balance of \$(.*) in my account")]
        public void GivenIHaveABalanceOfInMyAccount(int amount)
        {
            account = new Account();
            account.deposite(amount);
            domainHelper.getAccount().deposite(amount);
            Assert.AreEqual(amount, account.getBalance());
        }

        [When(@"I request \$(.*)")]
        public void WhenIRequest(int requestAmount)
        {
            Teller teller = new Teller();
            teller.withdrawCash(account,requestAmount);
        }

        [Then(@"\$(.*) should be dispensed")]
        public void ThenShouldBeDispensed(int p0)
        {
            
        }

    }

   
}
