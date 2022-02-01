using System;
using TechTalk.SpecFlow;
using Bank;

namespace BankSpecFlow.StepDefinitions
{
    [Binding]
    public class TransferTestStepDefinitions
    {
        CardAccount card = new CardAccount(0);
        CheckingAccount check = new CheckingAccount(0);
        decimal PizzaPrice = 0;

        [Given(@"Checking account has (.*) SEK")]
        public void GivenCheckingAccountHasSEK (int amount)
        {
            check = new CheckingAccount(amount);
        }

        [Given(@"a pizza \+ soda costs (.*) SEK")]
        public void GivenAPizzaSodaCostsSEK (int amount)
        {
            PizzaPrice = amount;
        }

        [When(@"money is transfered from checking account to card account")]
        public void WhenMoneyIsTransferedFromCheckingAccountToCardAccount ()
        {
            
        }
        [Given(@"card account has less than (.*)")]
        public void GivenCardAccountHasLessThan (int amount)
        {
            var rnd = new Random();
            card=new CardAccount(rnd.Next(amount-1));
        }


        [Then(@"the difference should be transfered")]
        public void ThenTheDifferenceShouldBeTransfered ()
        {
            var diff = PizzaPrice - card.Balance;
            if (diff>0)
            {
                check.Transfer(diff, card);
            }
        }

        [Then(@"the card account will have (.*)")]
        public void ThenTheCardAccountWillHave (decimal amount)
        {
            card.Balance.Should().Be(amount);
        }
    }
}
