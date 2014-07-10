namespace Kiosk
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.btnFind = new System.Windows.Forms.Button();
			this.lblFullName = new System.Windows.Forms.Label();
			this.lblBalance = new System.Windows.Forms.Label();
			this.txtAmount = new System.Windows.Forms.TextBox();
			this.btnDeposit = new System.Windows.Forms.Button();
			this.btnWithdraw = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtId);
			this.groupBox1.Controls.Add(this.btnFind);
			this.groupBox1.Location = new System.Drawing.Point(21, 31);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(939, 136);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Account Lookup";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnWithdraw);
			this.groupBox2.Controls.Add(this.btnDeposit);
			this.groupBox2.Controls.Add(this.txtAmount);
			this.groupBox2.Controls.Add(this.lblBalance);
			this.groupBox2.Controls.Add(this.lblFullName);
			this.groupBox2.Location = new System.Drawing.Point(21, 201);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(939, 412);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Account Information";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(137, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(233, 32);
			this.label1.TabIndex = 5;
			this.label1.Text = "Account Number:";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(389, 61);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(100, 38);
			this.txtId.TabIndex = 4;
			// 
			// btnFind
			// 
			this.btnFind.Location = new System.Drawing.Point(523, 55);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(143, 49);
			this.btnFind.TabIndex = 3;
			this.btnFind.Text = "Find";
			this.btnFind.UseVisualStyleBackColor = true;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// lblFullName
			// 
			this.lblFullName.AutoSize = true;
			this.lblFullName.Location = new System.Drawing.Point(52, 84);
			this.lblFullName.Name = "lblFullName";
			this.lblFullName.Size = new System.Drawing.Size(0, 32);
			this.lblFullName.TabIndex = 0;
			// 
			// lblBalance
			// 
			this.lblBalance.AutoSize = true;
			this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBalance.ForeColor = System.Drawing.Color.Blue;
			this.lblBalance.Location = new System.Drawing.Point(674, 34);
			this.lblBalance.Name = "lblBalance";
			this.lblBalance.Size = new System.Drawing.Size(0, 54);
			this.lblBalance.TabIndex = 1;
			// 
			// txtAmount
			// 
			this.txtAmount.Location = new System.Drawing.Point(283, 188);
			this.txtAmount.Name = "txtAmount";
			this.txtAmount.Size = new System.Drawing.Size(262, 38);
			this.txtAmount.TabIndex = 2;
			// 
			// btnDeposit
			// 
			this.btnDeposit.Location = new System.Drawing.Point(203, 260);
			this.btnDeposit.Name = "btnDeposit";
			this.btnDeposit.Size = new System.Drawing.Size(167, 59);
			this.btnDeposit.TabIndex = 3;
			this.btnDeposit.Text = "Deposit";
			this.btnDeposit.UseVisualStyleBackColor = true;
			this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
			// 
			// btnWithdraw
			// 
			this.btnWithdraw.Location = new System.Drawing.Point(499, 260);
			this.btnWithdraw.Name = "btnWithdraw";
			this.btnWithdraw.Size = new System.Drawing.Size(167, 59);
			this.btnWithdraw.TabIndex = 4;
			this.btnWithdraw.Text = "Withdraw";
			this.btnWithdraw.UseVisualStyleBackColor = true;
			this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(972, 644);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Bank Kiosk";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lblFullName;
		private System.Windows.Forms.Button btnWithdraw;
		private System.Windows.Forms.Button btnDeposit;
		private System.Windows.Forms.TextBox txtAmount;
		private System.Windows.Forms.Label lblBalance;

	}
}

