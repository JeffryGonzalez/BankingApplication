using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingDomain
{
	public class BankingContext : DbContext
	{
		public DbSet<Account> Accounts { get; set; } 
	}
}
