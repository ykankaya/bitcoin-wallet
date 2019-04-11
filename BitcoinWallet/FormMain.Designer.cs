namespace BitcoinWallet
{
	partial class FormMain
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.txtGenPrivateKey = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtGenAddress = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cmdGenerate = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label8 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblProcessing = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.lblAmount = new System.Windows.Forms.Label();
			this.txtDonationValue = new System.Windows.Forms.NumericUpDown();
			this.chkDonation = new System.Windows.Forms.CheckBox();
			this.label11 = new System.Windows.Forms.Label();
			this.cmdDonate = new System.Windows.Forms.Button();
			this.txtDonateAdderss = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtAmount = new System.Windows.Forms.NumericUpDown();
			this.txtFee = new System.Windows.Forms.NumericUpDown();
			this.label9 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.txtPrivateKey = new System.Windows.Forms.TextBox();
			this.cmdTransfer = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtToAddress = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtFromAddress = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cmdTransferValidation = new System.Windows.Forms.Button();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.lblVersion = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtDonationAbout = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtDonationValue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtFee)).BeginInit();
			this.tabPage3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(37, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(865, 595);
			this.tabControl1.TabIndex = 11;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.txtGenPrivateKey);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.txtGenAddress);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.cmdGenerate);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(857, 569);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Generate New Bitcoin Address And Private Key";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// txtGenPrivateKey
			// 
			this.txtGenPrivateKey.Location = new System.Drawing.Point(164, 129);
			this.txtGenPrivateKey.Name = "txtGenPrivateKey";
			this.txtGenPrivateKey.Size = new System.Drawing.Size(368, 20);
			this.txtGenPrivateKey.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(31, 106);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 13);
			this.label6.TabIndex = 7;
			this.label6.Text = "Address:";
			// 
			// txtGenAddress
			// 
			this.txtGenAddress.Location = new System.Drawing.Point(164, 103);
			this.txtGenAddress.Name = "txtGenAddress";
			this.txtGenAddress.Size = new System.Drawing.Size(368, 20);
			this.txtGenAddress.TabIndex = 8;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(31, 132);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(105, 13);
			this.label7.TabIndex = 9;
			this.label7.Text = "Address Private Key:";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(30, 193);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(502, 201);
			this.label5.TabIndex = 1;
			this.label5.Text = resources.GetString("label5.Text");
			// 
			// cmdGenerate
			// 
			this.cmdGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.cmdGenerate.Location = new System.Drawing.Point(34, 28);
			this.cmdGenerate.Name = "cmdGenerate";
			this.cmdGenerate.Size = new System.Drawing.Size(498, 50);
			this.cmdGenerate.TabIndex = 0;
			this.cmdGenerate.Text = "Generate";
			this.cmdGenerate.UseVisualStyleBackColor = true;
			this.cmdGenerate.Click += new System.EventHandler(this.cmdGenerate_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Controls.Add(this.panel1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(857, 569);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Transfer Bitcoin To Address";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label8.Location = new System.Drawing.Point(24, 12);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(424, 16);
			this.label8.TabIndex = 12;
			this.label8.Text = "Send Money From Your Bitcoin Address To Another Address";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lblProcessing);
			this.panel1.Controls.Add(this.progressBar1);
			this.panel1.Controls.Add(this.lblAmount);
			this.panel1.Controls.Add(this.txtDonationValue);
			this.panel1.Controls.Add(this.chkDonation);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.cmdDonate);
			this.panel1.Controls.Add(this.txtDonateAdderss);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.txtAmount);
			this.panel1.Controls.Add(this.txtFee);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.richTextBox1);
			this.panel1.Controls.Add(this.txtPrivateKey);
			this.panel1.Controls.Add(this.cmdTransfer);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtToAddress);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtFromAddress);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.cmdTransferValidation);
			this.panel1.Location = new System.Drawing.Point(27, 43);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(656, 505);
			this.panel1.TabIndex = 11;
			// 
			// lblProcessing
			// 
			this.lblProcessing.AutoSize = true;
			this.lblProcessing.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.lblProcessing.Location = new System.Drawing.Point(397, 216);
			this.lblProcessing.Name = "lblProcessing";
			this.lblProcessing.Size = new System.Drawing.Size(108, 18);
			this.lblProcessing.TabIndex = 23;
			this.lblProcessing.Text = "Processing...";
			this.lblProcessing.Visible = false;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(16, 245);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(509, 23);
			this.progressBar1.TabIndex = 22;
			this.progressBar1.Visible = false;
			// 
			// lblAmount
			// 
			this.lblAmount.AutoSize = true;
			this.lblAmount.Location = new System.Drawing.Point(531, 23);
			this.lblAmount.Name = "lblAmount";
			this.lblAmount.Size = new System.Drawing.Size(0, 13);
			this.lblAmount.TabIndex = 21;
			// 
			// txtDonationValue
			// 
			this.txtDonationValue.DecimalPlaces = 4;
			this.txtDonationValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
			this.txtDonationValue.Location = new System.Drawing.Point(178, 124);
			this.txtDonationValue.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            262144});
			this.txtDonationValue.Name = "txtDonationValue";
			this.txtDonationValue.Size = new System.Drawing.Size(120, 20);
			this.txtDonationValue.TabIndex = 20;
			this.txtDonationValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
			// 
			// chkDonation
			// 
			this.chkDonation.AutoSize = true;
			this.chkDonation.Checked = true;
			this.chkDonation.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkDonation.Location = new System.Drawing.Point(16, 127);
			this.chkDonation.Name = "chkDonation";
			this.chkDonation.Size = new System.Drawing.Size(123, 17);
			this.chkDonation.TabIndex = 19;
			this.chkDonation.Text = "Karma Donation Fee";
			this.chkDonation.UseVisualStyleBackColor = true;
			this.chkDonation.CheckedChanged += new System.EventHandler(this.chkDonation_CheckedChanged);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(13, 277);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(46, 13);
			this.label11.TabIndex = 18;
			this.label11.Text = "Log Info";
			// 
			// cmdDonate
			// 
			this.cmdDonate.Location = new System.Drawing.Point(400, 466);
			this.cmdDonate.Name = "cmdDonate";
			this.cmdDonate.Size = new System.Drawing.Size(75, 23);
			this.cmdDonate.TabIndex = 17;
			this.cmdDonate.Text = "Donate";
			this.cmdDonate.UseVisualStyleBackColor = true;
			this.cmdDonate.Click += new System.EventHandler(this.cmdDonate_Click);
			// 
			// txtDonateAdderss
			// 
			this.txtDonateAdderss.Location = new System.Drawing.Point(101, 469);
			this.txtDonateAdderss.Name = "txtDonateAdderss";
			this.txtDonateAdderss.Size = new System.Drawing.Size(266, 20);
			this.txtDonateAdderss.TabIndex = 16;
			this.txtDonateAdderss.Text = "1N8kXQ88dXxzY83baUL6SGmwmWX8iD21Es";
			this.txtDonateAdderss.DoubleClick += new System.EventHandler(this.txtDonateAdderss_DoubleClick);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(12, 476);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(83, 13);
			this.label10.TabIndex = 15;
			this.label10.Text = "Donate Address";
			// 
			// txtAmount
			// 
			this.txtAmount.DecimalPlaces = 8;
			this.txtAmount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
			this.txtAmount.Location = new System.Drawing.Point(178, 72);
			this.txtAmount.Name = "txtAmount";
			this.txtAmount.Size = new System.Drawing.Size(120, 20);
			this.txtAmount.TabIndex = 14;
			// 
			// txtFee
			// 
			this.txtFee.DecimalPlaces = 4;
			this.txtFee.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
			this.txtFee.Location = new System.Drawing.Point(178, 98);
			this.txtFee.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            262144});
			this.txtFee.Name = "txtFee";
			this.txtFee.Size = new System.Drawing.Size(120, 20);
			this.txtFee.TabIndex = 13;
			this.txtFee.Value = new decimal(new int[] {
            2,
            0,
            0,
            262144});
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(12, 98);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(78, 13);
			this.label9.TabIndex = 11;
			this.label9.Text = "Fee To Miners:";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(15, 293);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(510, 162);
			this.richTextBox1.TabIndex = 10;
			this.richTextBox1.Text = "";
			this.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox1_LinkClicked);
			// 
			// txtPrivateKey
			// 
			this.txtPrivateKey.Location = new System.Drawing.Point(178, 46);
			this.txtPrivateKey.Name = "txtPrivateKey";
			this.txtPrivateKey.Size = new System.Drawing.Size(347, 20);
			this.txtPrivateKey.TabIndex = 6;
			// 
			// cmdTransfer
			// 
			this.cmdTransfer.Enabled = false;
			this.cmdTransfer.Location = new System.Drawing.Point(205, 215);
			this.cmdTransfer.Name = "cmdTransfer";
			this.cmdTransfer.Size = new System.Drawing.Size(174, 23);
			this.cmdTransfer.TabIndex = 9;
			this.cmdTransfer.Text = "2. Transfer";
			this.cmdTransfer.UseVisualStyleBackColor = true;
			this.cmdTransfer.Click += new System.EventHandler(this.cmdTransfer_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "From Address:";
			// 
			// txtToAddress
			// 
			this.txtToAddress.Location = new System.Drawing.Point(178, 180);
			this.txtToAddress.Name = "txtToAddress";
			this.txtToAddress.Size = new System.Drawing.Size(347, 20);
			this.txtToAddress.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Amount to send:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 180);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "To Address:";
			// 
			// txtFromAddress
			// 
			this.txtFromAddress.Location = new System.Drawing.Point(178, 20);
			this.txtFromAddress.Name = "txtFromAddress";
			this.txtFromAddress.Size = new System.Drawing.Size(347, 20);
			this.txtFromAddress.TabIndex = 2;
			this.txtFromAddress.TextChanged += new System.EventHandler(this.txtFromAddress_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 46);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(105, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Address Private Key:";
			// 
			// cmdTransferValidation
			// 
			this.cmdTransferValidation.Location = new System.Drawing.Point(15, 215);
			this.cmdTransferValidation.Name = "cmdTransferValidation";
			this.cmdTransferValidation.Size = new System.Drawing.Size(174, 23);
			this.cmdTransferValidation.TabIndex = 4;
			this.cmdTransferValidation.Text = "1. Check Data Validation";
			this.cmdTransferValidation.UseVisualStyleBackColor = true;
			this.cmdTransferValidation.Click += new System.EventHandler(this.cmdValidation_Click);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.lblVersion);
			this.tabPage3.Controls.Add(this.label16);
			this.tabPage3.Controls.Add(this.txtEmail);
			this.tabPage3.Controls.Add(this.label13);
			this.tabPage3.Controls.Add(this.txtDonationAbout);
			this.tabPage3.Controls.Add(this.label14);
			this.tabPage3.Controls.Add(this.label12);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(857, 569);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "About";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// lblVersion
			// 
			this.lblVersion.AutoSize = true;
			this.lblVersion.Location = new System.Drawing.Point(16, 455);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.Size = new System.Drawing.Size(85, 13);
			this.lblVersion.TabIndex = 19;
			this.lblVersion.Text = "Version Number:";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(16, 506);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(349, 42);
			this.label16.TabIndex = 18;
			this.label16.Text = "Allow us to keep maintaining, add features and improve this wallet by supporting " +
    "us through a donation to this Bitcoin address: ";
			// 
			// txtEmail
			// 
			this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.txtEmail.Location = new System.Drawing.Point(135, 479);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.ReadOnly = true;
			this.txtEmail.Size = new System.Drawing.Size(214, 15);
			this.txtEmail.TabIndex = 17;
			this.txtEmail.Text = "btcprivatewallet@gmail.com";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(16, 479);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(98, 13);
			this.label13.TabIndex = 4;
			this.label13.Text = "Contact, Requests:";
			// 
			// txtDonationAbout
			// 
			this.txtDonationAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtDonationAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.txtDonationAbout.Location = new System.Drawing.Point(371, 506);
			this.txtDonationAbout.Name = "txtDonationAbout";
			this.txtDonationAbout.ReadOnly = true;
			this.txtDonationAbout.Size = new System.Drawing.Size(294, 17);
			this.txtDonationAbout.TabIndex = 3;
			this.txtDonationAbout.Text = "1N8kXQ88dXxzY83baUL6SGmwmWX8iD21Es";
			this.txtDonationAbout.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label14.ForeColor = System.Drawing.Color.Black;
			this.label14.Location = new System.Drawing.Point(15, 60);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(760, 408);
			this.label14.TabIndex = 2;
			this.label14.Text = resources.GetString("label14.Text");
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Miriam", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label12.Location = new System.Drawing.Point(15, 18);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(524, 21);
			this.label12.TabIndex = 0;
			this.label12.Text = "Why this simple wallet is the best wallet you can have";
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(934, 633);
			this.Controls.Add(this.tabControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormMain";
			this.Text = "Private Bitcoin Wallet";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtDonationValue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtFee)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtPrivateKey;
		private System.Windows.Forms.Button cmdTransfer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtToAddress;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtFromAddress;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button cmdTransferValidation;
		private System.Windows.Forms.TextBox txtGenPrivateKey;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtGenAddress;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button cmdGenerate;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.NumericUpDown txtFee;
		private System.Windows.Forms.NumericUpDown txtAmount;
		private System.Windows.Forms.TextBox txtDonateAdderss;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button cmdDonate;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.NumericUpDown txtDonationValue;
		private System.Windows.Forms.CheckBox chkDonation;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TextBox txtDonationAbout;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label lblAmount;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Label lblProcessing;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lblVersion;
		private System.Windows.Forms.TextBox txtEmail;
	}
}
