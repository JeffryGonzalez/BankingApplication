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
		private BankManager _manager = new BankManager();

		private void btnFind_Click(object sender, EventArgs e)
		{
			try
			{
				var accountId = int.Parse(txtId.Text);
				_currentAccount = _manager.Lookup(accountId);
				lblFullName.Text = string.Format("Account {0}:  {1}, {2}", _currentAccount.Id, _currentAccount.LastName,
					_currentAccount.FirstName);
				UpdateBalance();
				grpTransaction.Enabled = true;
			}
			catch (FormatException)
			{
				MessageBox.Show("Enter a Number, Please.");
			}
			catch (NoSuchAccountException)
			{
				MessageBox.Show("No Such Account");
			}
			finally
			{
				txtId.SelectAll();
				txtId.Focus();
			}


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
			try
			{
				var amount = decimal.Parse(txtAmount.Text);

				action(amount);
				UpdateBalance();
				txtAmount.Clear();
				_manager.Update(_currentAccount);
			}
			catch (FormatException)
			{
				MessageBox.Show("Enter a Number Please");
			}
			finally
			{
				txtAmount.SelectAll();
				txtAmount.Focus();
			}
		}

		private void btnWithdraw_Click(object sender, EventArgs e)
		{
			DoTransaction(_currentAccount.Withdraw);
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			_manager.Dispose();
		}



	}
}
