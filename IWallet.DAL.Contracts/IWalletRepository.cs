using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Wallet.Common.Entities.Amount;

namespace IWallet.DAL.Contracts
{
    public interface IWalletRepository
    {
        public void Add(AmountType type);
    }
}
