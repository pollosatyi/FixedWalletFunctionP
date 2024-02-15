using IWallet.BLL.Contracts;
using IWallet.DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wallet.Common.Entities;
using static Wallet.Common.Entities.Amount;

namespace Wallet.BLL
{
    public class WalletLogic: IWalletLogic
    {
        private readonly IWalletRepository _walletRepository;
        public WalletLogic(IWalletRepository walletRepository)
        {
            _walletRepository = walletRepository;
        }

        public void Create(Amount.AmountType type)
        {
            _walletRepository.Add(type);
        }
    }
}
