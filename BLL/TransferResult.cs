using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TransferResult
    {
		public bool Success { get; set; }
		public string Message { get; set; }
		public string ErrorCode { get; set; }
		public string Reason { get; set; }
		public string TransactionHex { get; set; }
		public string TransactionHash { get; set; }
		
	}
}
