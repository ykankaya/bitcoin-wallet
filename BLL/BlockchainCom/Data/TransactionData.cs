using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BlockchainCom.Data
{
	public class TransactionData
	{
		public string Message { get; set; }
		public int Ver { get; set; }
		public List<InputDetail> Inputs { get; set; }
		public int Weight { get; set; }
		public int Block_height { get; set; } //if you don't get block height, it's means the transaction did not enter to the block yet.
		public string Relayed_by { get; set; }
		public List<TransactionInfo> Out { get; set; }
		public int Lock_time { get; set; }
		public int Size { get; set; }
		public bool Double_Spend { get; set; } //Need to shadow this in address (only shown in transaction)
		public int Result { get; set; } //Only shown in adderss
		public int Time { get; set; }
		public long Tx_index { get; set; }
		public int Vin_sz { get; set; }
		public string Hash { get; set; }
		public string vout_sz { get; set; }


	}

	public class InputDetail
	{
		public long sequence { get; set; }
		public string Witness { get; set; }
		public TransactionInfo Prev_out { get; set; }
		public string Script { get; set; }
	}

	public class TransactionInfo
	{
		public bool Spent { get; set; }
		public long Tx_index { get; set; }
		public int Type { get; set; }
		public string Addr { get; set; }
		public long Value { get; set; }
		public int N { get; set; }
		public string Script { get; set; }

		
		public decimal MyAmount
		{
			get
			{
				return Value * BLL.Helper.Satoshi;
			}
		}
				
	}


}
