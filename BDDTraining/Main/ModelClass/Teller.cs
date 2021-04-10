
using BDDTraining.Main.ModelClass;

namespace BDDTraining.ModelClass
{
    internal class Teller
    {
        private CashSlot cashSlot;
        public Teller(CashSlot cashSlot)
        {
            this.cashSlot = cashSlot;
        }
        public void withdrawCash(Account account,int requestAmount)
        {
            cashSlot.dispense(requestAmount);
        }
    }
}
