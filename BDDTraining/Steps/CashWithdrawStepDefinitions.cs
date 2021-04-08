using TechTalk.SpecFlow;
using System;

namespace BDDTraining.Steps
{
    [Binding]
    public sealed class CashWithdrawStepDefinitions
    {
            private Account account;
            private CashSlot cashSlot;

            [Given(@"I have a balance of ${int} in my account")]
        public void GivenIHaveABalanceOfInMyAccount(int amount)
        {
            account = new Account();
            account.deposite(amount);
            assertEquals("Incorrect balance amount - ", amount,
            account.getBalance());

        }

        [When(@"I request \$(.*)")]
        public void WhenIRequest(int p0)
        {
            
        }

        [Then(@"\$(.*) should be dispensed")]
        public void ThenShouldBeDispensed(int p0)
        {
            
        }

    }
}
