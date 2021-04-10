
using BDDTraining.Main.ModelClass;
using BDDTraining.ModelClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDDTraining.HelperClass
{
    public class DomainHelper
    {
        private Account account;
        private CashSlot cashslot;
        private Teller teller;


        internal Account GetAccount(){

            if (account == null)
            {
                account = new Account();
            }
            return account;
        }

        internal CashSlot GetCashSlot()
        {

            if (cashslot == null)
            {
                cashslot = new CashSlot();
            }
            return cashslot;
        }

        internal Teller GetTeller()
        {

            if (teller == null)
            {
                teller = new Teller(GetCashSlot());
            }
            return teller;
        }
    }
}
