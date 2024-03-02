using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wallet.Common.Entities.Enums;

namespace Wallet.Common.Entities
{
    public class Amount
    {
        public long Id { get; set; } 
        public long UserId { get; set; }
        public AmountType AmountType { get; set; }
    }
}
