using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet.Common.Entities
{
    public class Amount
    {
        public enum AmountType
        {
            rub=1,
            eur,
            usd
        }
    }
}
