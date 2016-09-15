using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class BankAccount
    {
        public event EventHandler<OverdrawnEventArgs> Overdrawn;

        public decimal Balance { get; set; }

        public BankAccount(decimal balance)
        {
            this.Balance = balance;
        }

        public void Credit(decimal amount)
        {
            this.Balance += amount;
        }

        public void Debit(decimal amount)
        {
            if (this.Balance >= amount)
            {
                this.Balance -= amount;
            }
            else
            {
                if (Overdrawn != null)
                {
                    OnOverdrawn(new OverdrawnEventArgs(this.Balance, amount));
                }
            }
        }

        protected virtual void OnOverdrawn(OverdrawnEventArgs args)
        {
            if (Overdrawn != null)
            {
                Overdrawn(this, args);
            }
        }
    }
}
