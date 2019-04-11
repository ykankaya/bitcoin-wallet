using NBitcoin;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QBitNinja.Client.Models;
using QBitNinja.Client;
using System.Net;

namespace BLL
{
	public class Helper
	{
		public static  decimal Satoshi = 0.00000001m;
		public static decimal NumberOfConfirmations = 2; 
		public static Network GetNetwork(bool isTest = false)
		{
			var network = Network.Main;
			if (isTest)
			{
				network = Network.TestNet;
			}
			return network;
		}

		public static KeyAddress CreateKeyAddress(bool isTest = false)
		{
			var network = GetNetwork(isTest);
			KeyAddress keyAddress = new KeyAddress();
			var privateKey = new Key().ToString(network);
			var secret = new BitcoinSecret(privateKey, network);
			var key = secret.PrivateKey;
			var bitcoinaddress = key.PubKey.GetAddress(network);
			keyAddress.PubKey = key.PubKey;
			keyAddress.Address = bitcoinaddress.ToString();
			keyAddress.PrivateKey = privateKey;
			return keyAddress;
		}

		public static bool CheckValidPrivateKey(string privateKey, bool isTest = false)
		{
			try
			{
				var network = GetNetwork(isTest);
				var secret = new BitcoinSecret(privateKey, network);
			}
			catch (Exception ex)
			{
				//var message = "Key is not valid";
				return false;
			}
			return true;
		}

		public static bool IsPrivateKeyMatchAddress(string privateKey, string address, bool isTest = false)
		{
			try
			{
				var network = GetNetwork(isTest);
				var secret = new BitcoinSecret(privateKey, network);
				var key = secret.PrivateKey;
				var bitcoinaddress = key.PubKey.GetAddress(network);
				return bitcoinaddress.ToString() == address;
			}
			catch (Exception ex)
			{
				return false;
			}
			
		}

		public static bool CheckValidAddress(string address, bool isTest = false)
		{
			try
			{
				var network = GetNetwork(isTest);
				var destination = NBitcoin.BitcoinAddress.Create(address, network);
			}
			catch (Exception ex)
			{
				//var message = "BTC Address is not valid";
				return false;
			}
			return true;
		}

		private static Transaction CreateSignTransaction(string privateKey, string destinationAddress, List<TxIn> inputs, decimal amountToSend, decimal amountToReturn, bool isTest = false, decimal fee = 0.0005m, bool donation = false, decimal donationAmount = 0.001m, string donationAddress = "", string otherInfo = "")
		{
			try
			{
				var network = GetNetwork(isTest);
				var secret = new BitcoinSecret(privateKey, network);
				// key = secret.PrivateKey;
				Transaction transaction = new ConsensusFactory().CreateTransaction();

				foreach (var txIn in inputs)
				{
					txIn.ScriptSig = secret.GetAddress().ScriptPubKey;
					transaction.AddInput(txIn);
				}
				TxOut txout = new TxOut();
				var destination = BitcoinAddress.Create(destinationAddress, network);
				txout.ScriptPubKey = destination.ScriptPubKey;

				//Money moneyFee = Money.Satoshis(fee);
				Money moneyFee = Money.Coins(fee);
				Money moneyToSend = Money.Coins(amountToSend);
				txout.Value = moneyToSend - moneyFee; //the fee money is taken of from the buyer, so if you want to pay him more, add the fee to the money you send.

				transaction.AddOutput(txout);

				if (donation)
				{
					TxOut txoutDonation = new TxOut();
					var destinationDonation = BitcoinAddress.Create(donationAddress, network);
					txoutDonation.ScriptPubKey = destinationDonation.ScriptPubKey;
					txoutDonation.Value = Money.Coins(donationAmount);
					transaction.AddOutput(txoutDonation);
				}

				//incase there is a change we need to bring it back to the sender.
				if (amountToReturn > 0)
				{
					TxOut txoutChange = new TxOut();
					var returnDestination = BitcoinAddress.Create(secret.GetAddress().ToString(), network);
					txoutChange.ScriptPubKey = returnDestination.ScriptPubKey;
					txoutChange.Value = Money.Coins(amountToReturn);
					transaction.AddOutput(txoutChange);
				}

				transaction.Sign(secret, false);
				return transaction;
				//return transaction.GetHash().ToString();
				//transaction.ToHex().ToString() //Getting the Hex and pasting it in broadcast network like testNet blockcypher
			}
			catch (Exception ex)
			{
				throw new Exception("Error in CreateSignTransaction");
			}
		}


		public static T GetObjectFromURL<T>(string uri)
		{
			try
			{
				System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				var client = new System.Net.WebClient();
				
				var content = client.DownloadString(uri);
				var jsonResponse = JsonConvert.DeserializeObject<T>(content);
				return jsonResponse;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public static int GetBTCBlockCount(bool isTest = false)
		{
			
			var result = 0;
			try
			{
				string apiAddrress = BlockchainCom.API.GetAPIAddress(isTest);
				string uri = string.Format("{0}/q/getblockcount", apiAddrress);
				result = Helper.GetObjectFromURL<int>(uri);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return result;

		}

		public static int GetConfirmationNumber(int blockHeight, int lastBlock)
		{
			if (blockHeight <= 0 || blockHeight <= 0) //not yet on the system, or data of blockchain not valid.
			{
				return 0;
			}

			return (lastBlock - blockHeight + 1);
		}

		public static TxInHelper GetUnSpentTransactionFromAddress(string address, decimal amount, bool isTest = false)
		{
			try
			{
				var blockCount = isTest ? GetBTCBlockCount(true) : GetBTCBlockCount();
				TxInHelper txInHelper = new TxInHelper();
				txInHelper.inputs = new List<NBitcoin.TxIn>();
				List<NBitcoin.TxIn> inputs = new List<NBitcoin.TxIn>();
				var addressData = BLL.BlockchainCom.API.GetAddressDataByAddress(address, isTest);
				List<BLL.BlockchainCom.Data.TransactionData> unSpentList = new List<BLL.BlockchainCom.Data.TransactionData>();
				foreach (var item in addressData.Txs)
				{
					var outFound = item.Out.FirstOrDefault(p => p.Addr == address && p.Spent == false); //all the unspent btc from this address.
					if (outFound != null)
					{
						//Before adding this transaction check this is not a case for me sending to my self.
						var coinSendToItSelf = false;
						var meSending = item.Inputs.Count(p => p.Prev_out.Addr == address) == item.Inputs.Count();
						if (meSending) //which mean: I am the only one who send this transaction.
						{
							var meGetting = item.Out.Count(p => p.Addr == address) == item.Out.Count();
							if (meGetting)
							{
								coinSendToItSelf = true;
							}
						}
						if (coinSendToItSelf == false)
						{
							unSpentList.Add(item);
						}
					}
				}
				txInHelper.Sum = 0m;
				foreach (var item in unSpentList)
				{
					if (txInHelper.Sum > amount)
					{
						return txInHelper;
					}
					var TransactionHash = item.Hash;
					//Before I sent this money, I need to make sure that it has a few blocks over.
					var numberOfConfirmation = GetConfirmationNumber(item.Block_height, blockCount);
					var transactionCreatedByOwner = item.Inputs.FirstOrDefault(p => p.Prev_out.Addr == address);
					bool trustedTransaction = false;
					if (transactionCreatedByOwner != null && numberOfConfirmation >= 1) //trust your own transaction change.
					{
						trustedTransaction = true;
					}
					if (trustedTransaction || numberOfConfirmation >= NumberOfConfirmations)
					{
						var outData = item.Out.Where(p => p.Addr == address).FirstOrDefault(); //To my best understanding there can be only one out with my address
						if (outData != null)
						{
							txInHelper.Sum += outData.Value * Satoshi;
							NBitcoin.TxIn txIn = new NBitcoin.TxIn();
							txIn.PrevOut = new NBitcoin.OutPoint(new NBitcoin.uint256(TransactionHash), outData.N);
							txInHelper.inputs.Add(txIn);
						}
					}
				}
				return txInHelper;
			}
			catch (Exception ex)
			{
				throw ex ; 
			}
		}


		public static TransferResult TransferBit(string privateKeyFrom, string addressFrom, string destinationAddressToSendMoney, decimal amountToSend,   bool isTest = false, decimal fee = 0.0005m, bool donation = false, decimal donationAmount = 0.001m, string donationAddress = "", string otherInfo = "")
		{
			try
			{
				var transferResult = new TransferResult();
				var network = GetNetwork(isTest);
				var totalAmountToSend = amountToSend ; //Fee is not calculated because it's already deducted from the amountToSend
				if (donation)
				{
					totalAmountToSend += donationAmount; //adding the donation.
				}
				var txInHelper = GetUnSpentTransactionFromAddress(addressFrom, totalAmountToSend, isTest);
				decimal amountToReturn = txInHelper.Sum - totalAmountToSend ; 
				Transaction transaction = CreateSignTransaction(privateKeyFrom, destinationAddressToSendMoney, txInHelper.inputs, amountToSend, amountToReturn, isTest, fee, donation , donationAmount , donationAddress , otherInfo);
				if (transaction == null)
				{
					transferResult.Message = "Transaction Error";
					return transferResult;
				}
				transferResult.TransactionHex = transaction.ToHex().ToString();
				transferResult.TransactionHash = transaction.GetHash().ToString();

				QBitNinjaClient client = new QBitNinjaClient(network);
				BroadcastResponse broadcastResponse = client.Broadcast(transaction).Result;

				transferResult.Success = broadcastResponse.Success;
				//it's appear that even with an error, the broadcast is working.
				if (broadcastResponse.Error != null)
				{
					transferResult.Message = "Broadcast Error";
					transferResult.ErrorCode = broadcastResponse.Error.ErrorCode.ToString();
					transferResult.Reason = broadcastResponse.Error.Reason;
				}
				

				//if (!broadcastResponse.Success || broadcastResponse.Error != null)
				//{
				//	transferResult.Message = "Broadcast Error";
				//	return transferResult;
				//}

				//transferResult.Message = "Success";
				//transferResult.Success = true;
				return transferResult;


			}
			catch (Exception ex)
			{
				throw new Exception(ex.InnerException.Message);
			}
		}
	}
}
