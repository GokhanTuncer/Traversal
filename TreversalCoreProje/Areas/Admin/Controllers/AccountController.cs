using BusinessLayer.Abstract.AbstractUoW;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TreversalCoreProje.Areas.Admin.Models;

namespace TreversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class AccountController : Controller
    {
        public readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(AccountViewModel model)
        {
            var valueSender = _accountService.TGetByID(model.SenderID);
            var valueReceiver = _accountService.TGetByID(model.ReceiverID);
            //senderid,receiverid,amount

            valueSender.Balance -= model.Amount;
            valueReceiver.Balance += model.Amount;

            List<Account> modifiedAccounts = new List<Account>()
            {
                valueSender,
                valueReceiver
            };

            _accountService.TMultiUpdate(modifiedAccounts);

            return View();
        }
    }
}
