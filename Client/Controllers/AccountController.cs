using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Orleans;
using Grain.Interfaces;

namespace Client.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IClusterClient client;

        public AccountController(IClusterClient _client)
        {
            client = _client;
        }

        //[HttpPost("create/{accountGuid}")]
        //public async Task<Guid> CreateAccount(string accountGuid)
        //{
        //    var grain = client.GetGrain<IAccount>(new Guid(accountGuid));
        //    return grain.GetPrimaryKey();
        //}

        [HttpGet("{accountGuid}")]
        public async Task<double> GetAccountBalance(string accountGuid) // change type to guid
        {
            var grain = client.GetGrain<IAccount>(new Guid(accountGuid));
            var balance = await grain.GetBalance();
            return balance;
        }

        [HttpPost("{accountGuid}/credit/{amount}")]
        public async Task CreditAmount(string accountGuid, double amount)
        {
            var grain = client.GetGrain<IAccount>(new Guid(accountGuid));
            await grain.Credit(amount);
        }

        [HttpPost("{accountGuid}/debit/{amount}")]
        public async Task DebitAmount(string accountGuid, double amount)
        {
            var grain = client.GetGrain<IAccount>(new Guid(accountGuid));
            await grain.Debit(amount);
        }

    }
}