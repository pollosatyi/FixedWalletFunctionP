using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Wallet.Common.Entities.Amount;

namespace IWallet.BLL.Contracts
{
    public interface IWalletLogic
    {
        public void Create (AmountType type);
    }
}
