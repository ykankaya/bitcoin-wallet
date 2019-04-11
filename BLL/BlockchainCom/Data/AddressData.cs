using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BlockchainCom.Data
{
	public class AddressData
	{
		public string Hash160 { get; set; }
		public string Address { get; set; }
		public int N_tx { get; set; }
		public long Total_received { get; set; }
		public long Total_sent { get; set; }
		public long Final_balance { get; set; }
		public List<TransactionData> Txs { get; set; }

	}

	
}
