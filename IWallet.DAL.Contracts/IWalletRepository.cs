using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wallet.Common.Entities;

namespace IWallet.DAL.Contracts
{
    public interface IWalletRepository
    {
        public void Add(Amount type);
    }
}
