using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BlockchainCom
{
	public class API
	{

		public static string GetAPIAddress(bool isTest = false)
		{
			if (isTest == false)
			{
				return "https://blockchain.info";
			}
			return "https://testnet.blockchain.info";

		}

		
		public static Data.AddressData GetAddressDataByAddress(string address, bool isTest = false, int? userId = null)
		{
			try
			{
				string apiAddrress = GetAPIAddress(isTest);
				string uri = string.Format("{0}/rawaddr/{1}", apiAddrress, address);
				var res = Helper.GetObjectFromURL<Data.AddressData>(uri);
				return res;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public static Data.TransactionData GetTransactionDataByTxId(string txId, bool isTest = false, int? userId = null)
		{
			try
			{
				string apiAddrress = GetAPIAddress(isTest);
				string uri = string.Format("{0}/rawtx/{1}", apiAddrress, txId);
				var res = Helper.GetObjectFromURL<Data.TransactionData>(uri);
				return res;
			}
			catch (Exception ex)
			{
				if (ex.Message.Contains("The remote server returned an error: (500) Internal Server Error"))
				{
					return null;
				}
				throw ex;
			}
		}




	}
}
