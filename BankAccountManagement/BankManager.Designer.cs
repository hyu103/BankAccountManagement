namespace BankAccountManagement
{
    partial class BankManager
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
            this.lblBankAccounts = new System.Windows.Forms.Label();
            this.lbBankAccounts = new System.Windows.Forms.ListBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.btnCreateCustomer = new System.Windows.Forms.Button();
            this.rbChequing = new System.Windows.Forms.RadioButton();
            this.rbSavings = new System.Windows.Forms.RadioButton();
            this.lblAmount = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.lblChequingBalance = new System.Windows.Forms.Label();
            this.lblSavingsBalance = new System.Windows.Forms.Label();
            this.lblSummaryInformation = new System.Windows.Forms.Label();
            this.gbCreateCustomer = new System.Windows.Forms.GroupBox();
            this.gbTransaction = new System.Windows.Forms.GroupBox();
            this.gbSummaryInformation = new System.Windows.Forms.GroupBox();
            this.lblSummaryBalance = new System.Windows.Forms.Label();
            this.lblSummaryCustomer = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.tbChequingBalance = new System.Windows.Forms.TextBox();
            this.tbSavingsBalance = new System.Windows.Forms.TextBox();
            this.gbCreateCustomer.SuspendLayout();
            this.gbTransaction.SuspendLayout();
            this.gbSummaryInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBankAccounts
            // 
            this.lblBankAccounts.AutoSize = true;
            this.lblBankAccounts.Location = new System.Drawing.Point(12, 21);
            this.lblBankAccounts.Name = "lblBankAccounts";
            this.lblBankAccounts.Size = new System.Drawing.Size(80, 13);
            this.lblBankAccounts.TabIndex = 0;
            this.lblBankAccounts.Text = "&Bank Accounts";
            // 
            // lbBankAccounts
            // 
            this.lbBankAccounts.FormattingEnabled = true;
            this.lbBankAccounts.Location = new System.Drawing.Point(15, 37);
            this.lbBankAccounts.Name = "lbBankAccounts";
            this.lbBankAccounts.Size = new System.Drawing.Size(219, 251);
            this.lbBankAccounts.TabIndex = 1;
            this.lbBankAccounts.SelectedIndexChanged += new System.EventHandler(this.lbBankAccounts_SelectedIndexChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(6, 30);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "&First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(6, 69);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "&Last Name";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(92, 30);
            this.tbFirstName.MaxLength = 40;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(152, 20);
            this.tbFirstName.TabIndex = 3;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(92, 66);
            this.tbLastName.MaxLength = 40;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(152, 20);
            this.tbLastName.TabIndex = 5;
            // 
            // btnCreateCustomer
            // 
            this.btnCreateCustomer.Location = new System.Drawing.Point(6, 96);
            this.btnCreateCustomer.Name = "btnCreateCustomer";
            this.btnCreateCustomer.Size = new System.Drawing.Size(141, 23);
            this.btnCreateCustomer.TabIndex = 6;
            this.btnCreateCustomer.Text = "C&reate Customer";
            this.btnCreateCustomer.UseVisualStyleBackColor = true;
            this.btnCreateCustomer.Click += new System.EventHandler(this.btnCreateCustomer_Click);
            // 
            // rbChequing
            // 
            this.rbChequing.AutoSize = true;
            this.rbChequing.Checked = true;
            this.rbChequing.Location = new System.Drawing.Point(6, 19);
            this.rbChequing.Name = "rbChequing";
            this.rbChequing.Size = new System.Drawing.Size(70, 17);
            this.rbChequing.TabIndex = 0;
            this.rbChequing.TabStop = true;
            this.rbChequing.Text = "&Chequing";
            this.rbChequing.UseVisualStyleBackColor = true;
            // 
            // rbSavings
            // 
            this.rbSavings.AutoSize = true;
            this.rbSavings.Location = new System.Drawing.Point(6, 42);
            this.rbSavings.Name = "rbSavings";
            this.rbSavings.Size = new System.Drawing.Size(63, 17);
            this.rbSavings.TabIndex = 1;
            this.rbSavings.Text = "&Savings";
            this.rbSavings.UseVisualStyleBackColor = true;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(112, 23);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "&Amount";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(115, 42);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(134, 20);
            this.tbAmount.TabIndex = 3;
            this.tbAmount.TextChanged += new System.EventHandler(this.tbAmount_TextChanged);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Enabled = false;
            this.btnDeposit.Location = new System.Drawing.Point(6, 69);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(99, 23);
            this.btnDeposit.TabIndex = 4;
            this.btnDeposit.Text = "&Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Enabled = false;
            this.btnWithdraw.Location = new System.Drawing.Point(130, 69);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(99, 23);
            this.btnWithdraw.TabIndex = 5;
            this.btnWithdraw.Text = "&Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // lblChequingBalance
            // 
            this.lblChequingBalance.AutoSize = true;
            this.lblChequingBalance.Location = new System.Drawing.Point(12, 309);
            this.lblChequingBalance.Name = "lblChequingBalance";
            this.lblChequingBalance.Size = new System.Drawing.Size(94, 13);
            this.lblChequingBalance.TabIndex = 18;
            this.lblChequingBalance.Text = "Chequing Balance";
            // 
            // lblSavingsBalance
            // 
            this.lblSavingsBalance.AutoSize = true;
            this.lblSavingsBalance.Location = new System.Drawing.Point(12, 357);
            this.lblSavingsBalance.Name = "lblSavingsBalance";
            this.lblSavingsBalance.Size = new System.Drawing.Size(87, 13);
            this.lblSavingsBalance.TabIndex = 20;
            this.lblSavingsBalance.Text = "Savings Balance";
            // 
            // lblSummaryInformation
            // 
            this.lblSummaryInformation.AutoSize = true;
            this.lblSummaryInformation.Location = new System.Drawing.Point(6, 27);
            this.lblSummaryInformation.Name = "lblSummaryInformation";
            this.lblSummaryInformation.Size = new System.Drawing.Size(0, 13);
            this.lblSummaryInformation.TabIndex = 23;
            // 
            // gbCreateCustomer
            // 
            this.gbCreateCustomer.Controls.Add(this.lblFirstName);
            this.gbCreateCustomer.Controls.Add(this.lblLastName);
            this.gbCreateCustomer.Controls.Add(this.tbFirstName);
            this.gbCreateCustomer.Controls.Add(this.tbLastName);
            this.gbCreateCustomer.Controls.Add(this.btnCreateCustomer);
            this.gbCreateCustomer.Location = new System.Drawing.Point(255, 21);
            this.gbCreateCustomer.Name = "gbCreateCustomer";
            this.gbCreateCustomer.Size = new System.Drawing.Size(260, 134);
            this.gbCreateCustomer.TabIndex = 24;
            this.gbCreateCustomer.TabStop = false;
            this.gbCreateCustomer.Text = "Create Customer";
            // 
            // gbTransaction
            // 
            this.gbTransaction.Controls.Add(this.rbChequing);
            this.gbTransaction.Controls.Add(this.rbSavings);
            this.gbTransaction.Controls.Add(this.lblAmount);
            this.gbTransaction.Controls.Add(this.tbAmount);
            this.gbTransaction.Controls.Add(this.btnDeposit);
            this.gbTransaction.Controls.Add(this.btnWithdraw);
            this.gbTransaction.Location = new System.Drawing.Point(255, 174);
            this.gbTransaction.Name = "gbTransaction";
            this.gbTransaction.Size = new System.Drawing.Size(266, 114);
            this.gbTransaction.TabIndex = 25;
            this.gbTransaction.TabStop = false;
            this.gbTransaction.Text = "Transaction";
            // 
            // gbSummaryInformation
            // 
            this.gbSummaryInformation.Controls.Add(this.lblSummaryBalance);
            this.gbSummaryInformation.Controls.Add(this.lblSummaryCustomer);
            this.gbSummaryInformation.Controls.Add(this.lblSummaryInformation);
            this.gbSummaryInformation.Location = new System.Drawing.Point(255, 309);
            this.gbSummaryInformation.Name = "gbSummaryInformation";
            this.gbSummaryInformation.Size = new System.Drawing.Size(266, 87);
            this.gbSummaryInformation.TabIndex = 26;
            this.gbSummaryInformation.TabStop = false;
            this.gbSummaryInformation.Text = "Summary Information";
            // 
            // lblSummaryBalance
            // 
            this.lblSummaryBalance.Location = new System.Drawing.Point(30, 48);
            this.lblSummaryBalance.Name = "lblSummaryBalance";
            this.lblSummaryBalance.Size = new System.Drawing.Size(219, 23);
            this.lblSummaryBalance.TabIndex = 29;
            this.lblSummaryBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSummaryCustomer
            // 
            this.lblSummaryCustomer.Location = new System.Drawing.Point(27, 22);
            this.lblSummaryCustomer.Name = "lblSummaryCustomer";
            this.lblSummaryCustomer.Size = new System.Drawing.Size(222, 23);
            this.lblSummaryCustomer.TabIndex = 28;
            this.lblSummaryCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(446, 402);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbChequingBalance
            // 
            this.tbChequingBalance.Location = new System.Drawing.Point(12, 329);
            this.tbChequingBalance.Name = "tbChequingBalance";
            this.tbChequingBalance.ReadOnly = true;
            this.tbChequingBalance.Size = new System.Drawing.Size(219, 20);
            this.tbChequingBalance.TabIndex = 7;
            // 
            // tbSavingsBalance
            // 
            this.tbSavingsBalance.Location = new System.Drawing.Point(15, 376);
            this.tbSavingsBalance.Name = "tbSavingsBalance";
            this.tbSavingsBalance.ReadOnly = true;
            this.tbSavingsBalance.Size = new System.Drawing.Size(219, 20);
            this.tbSavingsBalance.TabIndex = 8;
            // 
            // BankManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 440);
            this.Controls.Add(this.tbChequingBalance);
            this.Controls.Add(this.tbSavingsBalance);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbSummaryInformation);
            this.Controls.Add(this.gbTransaction);
            this.Controls.Add(this.gbCreateCustomer);
            this.Controls.Add(this.lblSavingsBalance);
            this.Controls.Add(this.lblChequingBalance);
            this.Controls.Add(this.lbBankAccounts);
            this.Controls.Add(this.lblBankAccounts);
            this.Name = "BankManager";
            this.Text = "Bank Account Management";
            this.Load += new System.EventHandler(this.BankManager_Load);
            this.gbCreateCustomer.ResumeLayout(false);
            this.gbCreateCustomer.PerformLayout();
            this.gbTransaction.ResumeLayout(false);
            this.gbTransaction.PerformLayout();
            this.gbSummaryInformation.ResumeLayout(false);
            this.gbSummaryInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBankAccounts;
        private System.Windows.Forms.ListBox lbBankAccounts;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Button btnCreateCustomer;
        private System.Windows.Forms.RadioButton rbChequing;
        private System.Windows.Forms.RadioButton rbSavings;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label lblChequingBalance;
        private System.Windows.Forms.Label lblSavingsBalance;
        private System.Windows.Forms.Label lblSummaryInformation;
        private System.Windows.Forms.GroupBox gbCreateCustomer;
        private System.Windows.Forms.GroupBox gbTransaction;
        private System.Windows.Forms.GroupBox gbSummaryInformation;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSummaryBalance;
        private System.Windows.Forms.Label lblSummaryCustomer;
        private System.Windows.Forms.TextBox tbChequingBalance;
        private System.Windows.Forms.TextBox tbSavingsBalance;
    }
}

