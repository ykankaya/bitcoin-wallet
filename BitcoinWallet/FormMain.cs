using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitcoinWallet
{
	public partial class FormMain : Form
	{
		//private bool isTest = true;
		public FormMain()
		{
			InitializeComponent();
			backgroundWorker1.RunWorkerAsync();
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			txtEmail.BackColor = Color.White;// tabControl1.BackColor;
			txtDonationAbout.BackColor = Color.White; //tabPage3.BackColor;
			lblVersion.Text = "Version: " + System.Windows.Forms.Application.ProductVersion;
		}

		private void cmdGenerate_Click(object sender, EventArgs e)
		{
			var res = BLL.Helper.CreateKeyAddress();
			txtGenAddress.Text = res.Address;
			txtGenPrivateKey.Text = res.PrivateKey;
		}

		private bool ValidateTransferData()
		{
			txtFromAddress.BorderStyle = BorderStyle.None;
			txtToAddress.BorderStyle = BorderStyle.None;
			txtAmount.BorderStyle = BorderStyle.None;
			txtFee.BorderStyle = BorderStyle.None;
			lblAmount.BorderStyle = BorderStyle.None;
			txtPrivateKey.BorderStyle = BorderStyle.None;
			richTextBox1.Text = "";
			
			txtFromAddress.Text = txtFromAddress.Text.Trim();
			txtToAddress.Text = txtToAddress.Text.Trim();
			var validFromAddress = BLL.Helper.CheckValidAddress(txtFromAddress.Text);
			var validToAddress = BLL.Helper.CheckValidAddress(txtToAddress.Text);
			var validPrivateKey = false;// BLL.Helper.CheckValidPrivateKey(txtPrivateKey.Text);
			var validFee = true;
			var validAmount = true;
			var validBalance = false;
			var transactionInProcess = false;
			
			
			if (validFromAddress==false)
			{
				richTextBox1.AppendText(GetNewLine(richTextBox1.Text) + "From Address is not valid");
				txtFromAddress.BorderStyle = BorderStyle.FixedSingle;
			}
			if (validToAddress == false)
			{
				richTextBox1.AppendText(GetNewLine(richTextBox1.Text) + "To Address is not valid");
				txtToAddress.BorderStyle = BorderStyle.FixedSingle;
			}

			if (txtAmount.Value <= 0)
			{
				richTextBox1.AppendText(GetNewLine(richTextBox1.Text) + "Amount can't be zero");
				validAmount = false;
				txtAmount.BorderStyle = BorderStyle.FixedSingle;
			}
			if (txtFee.Value<=0)
			{
				richTextBox1.AppendText(GetNewLine(richTextBox1.Text) + "Miner fee can't be zero");
				validFee = false;
				txtFee.BorderStyle = BorderStyle.FixedSingle;
			}
			else if (txtFee.Value >= 0.01m)
			{
				richTextBox1.AppendText(GetNewLine(richTextBox1.Text) + "Miner fee can't be bigger than 0.01");
				validFee = false;
				txtFee.BorderStyle = BorderStyle.FixedSingle;
			}

			if (validFromAddress)
			{
				var url = "https://www.blockchain.com/btc/address/" + txtFromAddress.Text;
				var addressData = BLL.BlockchainCom.API.GetAddressDataByAddress(txtFromAddress.Text);
				var balance = addressData.Final_balance * BLL.Helper.Satoshi;
				lblAmount.Text = balance.ToString() + " BTC";
				decimal amountToReturn = balance - txtAmount.Value - txtFee.Value;
				if (amountToReturn < 0)
				{
					
					var amountPlusFee = (txtAmount.Value + txtFee.Value);
					richTextBox1.AppendText(GetNewLine(richTextBox1.Text) + "In your from address: " + txtFromAddress.Text + " there is a balance of: " + balance + " BTC, ");
					richTextBox1.AppendText("this balance is lower than the amount you wish to send + fee, which is: " + amountPlusFee + " BTC");
					richTextBox1.AppendText(Environment.NewLine + "Please check your balance in the blockchain: " + url);
					validBalance = false;
					lblAmount.BorderStyle = BorderStyle.FixedSingle;
					txtAmount.BorderStyle = BorderStyle.FixedSingle;
				}
				else
				{
					validBalance = true;
				}

				//make another check to see if the amount we have is not under confirmation
			


				validPrivateKey = BLL.Helper.IsPrivateKeyMatchAddress(txtPrivateKey.Text, txtFromAddress.Text);
				if (validPrivateKey == false)
				{
					richTextBox1.AppendText(GetNewLine(richTextBox1.Text) + "Private key does not match to the from address");
					txtFromAddress.BorderStyle = BorderStyle.FixedSingle;
					txtPrivateKey.BorderStyle = BorderStyle.FixedSingle;
				}

				if (validBalance && validAmount && validFee)
				{
					var totalAmountToSend = txtAmount.Value;//Fee is not calculated because it's already deducted from the amountToSend
					if (chkDonation.Checked)
					{
						totalAmountToSend += txtDonationValue.Value; //adding the donation.
					}
					var txInHelper = BLL.Helper.GetUnSpentTransactionFromAddress(txtFromAddress.Text, totalAmountToSend);
					if (txInHelper.Sum == 0)
					{
						transactionInProcess = true;
					}
					else if (txInHelper.Sum < totalAmountToSend)
					{
						transactionInProcess = true;
					}
					if (transactionInProcess)
					{
						richTextBox1.AppendText("It could be that there is a transaction in process, you need to wait until it end");
						richTextBox1.AppendText(Environment.NewLine + "Please check your transaction in the blockchain: " + url);
					}
				}
				
			}
			return (validFromAddress && validToAddress && validFee && validAmount && validBalance && validPrivateKey && transactionInProcess==false);
		}

		private string GetNewLine(string text)
		{
			if (string.IsNullOrEmpty(text))
			{
				return text;
			}
			return Environment.NewLine;
		}
		private void cmdValidation_Click(object sender, EventArgs e)
		{

			Loading(true);
			
			var res = ValidateTransferData();
			cmdTransfer.Enabled = res;
			if (res == false)
			{
				cmdTransfer.BackColor  = default(Color);
				Loading(false);
				return;
			}
			richTextBox1.AppendText(GetNewLine(richTextBox1.Text) + "You may start the transfer process, click on the transfer button");
			cmdTransfer.BackColor = Color.Green;
			Loading(false);


		}

		private void DisableEnableTranferButton(bool enable)
		{
			cmdTransfer.Enabled = enable;
			if (enable)
			{
				cmdTransfer.BackColor = Color.Green;
			}
			else
			{
				cmdTransfer.BackColor = default(Color);
				
			}
		}
		

		private void cmdTransfer_Click(object sender, EventArgs e)
		{
			Loading(true);
			cmdTransfer.Enabled = false;
			var res = ValidateTransferData();
			cmdTransfer.Enabled = res;
			if (res==false)
			{
				cmdTransfer.BackColor = default(Color);
				cmdTransfer.Enabled = false;
				Loading(false);
				return;
			}
			
			BLL.TransferResult transferResult = null;
			try
			{
				transferResult = BLL.Helper.TransferBit(txtPrivateKey.Text, txtFromAddress.Text, txtToAddress.Text, txtAmount.Value, false, txtFee.Value, chkDonation.Checked, txtDonationValue.Value, txtDonateAdderss.Text );
				

				var url = "https://www.blockchain.com/btc/address/" + txtFromAddress.Text;
				if (transferResult.Success && string.IsNullOrEmpty(transferResult.ErrorCode))
				{
					richTextBox1.AppendText("Congratulations, Your request has been successfully sent to the blockchain network, please wait until the network will confirm your payment");
					richTextBox1.AppendText(Environment.NewLine + "You can check your balance and confirmation in the blockchain: " + url);
					DisableEnableTranferButton(false);
				}
				else if (transferResult.Success && string.IsNullOrEmpty(transferResult.ErrorCode)==false)
				{
					richTextBox1.AppendText("Pending, Your request has been successfully sent to the blockchain network, Please wait a few minutes for the confirmation to appear in the blockchain");
					richTextBox1.AppendText(Environment.NewLine + "To confirm your payment, you can check your balance and confirmation in the blockchain: " + url);
					DisableEnableTranferButton(false);
				}
				else {
					richTextBox1.AppendText("There was an error while trying to create this transaction");
					richTextBox1.AppendText(GetNewLine(richTextBox1.Text) + transferResult.Message);
				}
			}
			catch (Exception ex)
			{
				richTextBox1.AppendText("There was an error while trying to create this transaction");
				richTextBox1.AppendText(Environment.NewLine + ex.Message);
				cmdTransfer.Enabled = true;
				Loading(false);
				return;
			}

			Loading(false);
		}

		private void cmdDonate_Click(object sender, EventArgs e)
		{
			txtToAddress.Text = txtDonateAdderss.Text;
		}

		private void txtDonateAdderss_DoubleClick(object sender, EventArgs e)
		{
			txtToAddress.Text = txtDonateAdderss.Text;
		}

		private void chkDonation_CheckedChanged(object sender, EventArgs e)
		{
			txtDonationValue.Enabled = chkDonation.Checked;
		}

		

		private void txtFromAddress_TextChanged(object sender, EventArgs e)
		{
			txtFromAddress.BorderStyle = BorderStyle.None;
			if (string.IsNullOrEmpty(txtFromAddress.Text))
			{
				lblAmount.Text = "Insert your address";
			}
			txtFromAddress.Text = txtFromAddress.Text.Trim();
			var validFromAddress = BLL.Helper.CheckValidAddress(txtFromAddress.Text);
			if (validFromAddress==false)
			{
				lblAmount.Text = "Address is not valid";
				return;
			}
			var res =  BLL.BlockchainCom.API.GetAddressDataByAddress(txtFromAddress.Text);
			lblAmount.Text = (res.Final_balance * BLL.Helper.Satoshi).ToString() + " BTC";
			txtPrivateKey.Focus();
		}

		private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(e.LinkText);
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void Loading(bool processing = true)
		{
			progressBar1.Style = ProgressBarStyle.Marquee;
			progressBar1.Value = 0;
			progressBar1.Step = 1;
			progressBar1.Visible = processing;
			timer1.Enabled = processing;
			if (processing)
			{
				backgroundWorker1.RunWorkerAsync();
				Cursor = Cursors.WaitCursor;

			}
			else
			{
				Cursor = Cursors.Arrow;
			}

		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			lblProcessing.Visible = true;
			progressBar1.Value += 2;
			if (progressBar1.Value>98)
			{
				timer1.Enabled = false;
				lblProcessing.Visible = false;
			}
		}

		
	}
}
