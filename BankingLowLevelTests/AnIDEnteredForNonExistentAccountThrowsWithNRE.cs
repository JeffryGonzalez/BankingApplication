using System;
using BankingDomain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingLowLevelTests
{
	[TestClass]
	public class AnIDEnteredForNonExistentAccountThrowsWithNRE
	{
		[TestMethod][ExpectedException(typeof(NoSuchAccountException))]
		public void BadAccountIdThrows()
		{
			using (var bankManager = new BankManager())
			{
				bankManager.Lookup(99);
			}
		}
	}
}
