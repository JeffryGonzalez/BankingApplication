using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using BankingDomain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingLowLevelTests
{
	[TestClass]
	public class SetupForTests
	{
		[AssemblyInitialize]
		public static void Init(TestContext context)
		{
			Database.SetInitializer(new DropCreateDatabaseAlways<BankingContext>());
		}

	}

	public class InitializeTheDatabase : DropCreateDatabaseAlways<BankingContext>
	{
		protected override void Seed(BankingContext context)
		{
			var account1 = new Account() {FirstName = "Joe", LastName = "Schmidt"};
			account1.Deposit(3000);

			var account2 = new Account() {FirstName = "Sam", LastName = "Abshire"};
			account2.Deposit(180);

			var account3 = new Account() {FirstName = "Gena", LastName = "Rowlands"};
			account3.Deposit(23000);

			context.Accounts.AddRange(new Account[] {account1, account2, account3});

		}
	}
}
