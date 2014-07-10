using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingDomain
{
	public class BankManager : IDisposable
	{
		private BankingContext _context = new BankingContext();

		public Account Lookup(int id)
		{
			var account = _context.Accounts.Find(id);
			return account;
		}


		public void Update(Account account)
		{
			_context.SaveChanges();
		}
		public void Dispose()
		{
			_context.Dispose();
		}
	}
}
