using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingDomain
{
	public class Account
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public decimal Balance { get; private set; }

		public void Deposit(decimal amount)
		{
			Balance += amount;
		}

		public void Withdraw(decimal amount)
		{
			Balance -= amount;
		}
	}
}
