using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wallet.Common.Entities;

namespace IWallet.BLL.Contracts
{
    public interface IWalletLogic
    {
        public void Create (Amount type);
    }
}
