using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class OverdrawnEventArgs : EventArgs
    {
        public decimal CurrentBalance { get; set; }

        public decimal DebitAmount { get; set; }

        public OverdrawnEventArgs(decimal currentBalance, decimal debitAmount)
        {
            this.CurrentBalance = currentBalance;
            this.DebitAmount = debitAmount;
        }
    }
}
