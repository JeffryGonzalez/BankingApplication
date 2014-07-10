using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankingDomain;

namespace Kiosk
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private Account _currentAccount;
		private BankingContext _context = new BankingContext();

		private void btnFind_Click(object sender, EventArgs e)
		{
			var accountId = int.Parse(txtId.Text);

			
				_currentAccount = _context.Accounts.Find(accountId);
				lblFullName.Text = string.Format("Account {0}:  {1}, {2}", _currentAccount.Id, _currentAccount.LastName,
					_currentAccount.FirstName);
				UpdateBalance();
			

		}

		private void UpdateBalance()
		{
			lblBalance.Text = _currentAccount.Balance.ToString("c");
		}

		private void btnDeposit_Click(object sender, EventArgs e)
		{
			DoTransaction(_currentAccount.Deposit);
		}

		public void DoTransaction(Action<decimal> action)
		{
			var amount = decimal.Parse(txtAmount.Text);
		
				action(amount);
				UpdateBalance();
				txtAmount.Clear();
				_context.SaveChanges();
		}

		private void btnWithdraw_Click(object sender, EventArgs e)
		{
			DoTransaction(_currentAccount.Withdraw);
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			_context.Dispose();
		}

		
		
	}
}
