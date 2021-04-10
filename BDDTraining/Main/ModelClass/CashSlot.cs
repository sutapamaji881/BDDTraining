using System;
using System.Collections.Generic;
using System.Text;

namespace BDDTraining.Main.ModelClass
{
    class CashSlot
    {
        private int content;
        public int GetContents()
        {
            return content;
        }

        public void dispense(int requestAmount)
        {
            content = requestAmount;
        }
    }
}
