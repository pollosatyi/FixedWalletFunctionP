using IWallet.BLL.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Wallet.Common.Entities.Amount;

namespace UserWallet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : Controller
    {
        private readonly IWalletLogic _walletlogic;

        public TaskController(IWalletLogic walletlogic)
        {
            _walletlogic = walletlogic;
        }



        // POST: TaskController/Create
        [HttpPost]
        public void Post([FromBody] AmountType type)
        {
            _walletlogic.Create(type);
        }
    }
}
