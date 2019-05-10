using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Grain.Interfaces;
using Microsoft.Extensions.Logging;
using Orleans;
using Resources;
using Orleans.Providers;
using Grain.Interfaces.States;

namespace Grain
{
    [StorageProvider(ProviderName = Constants.OrleansMemoryProvider)]
    public class Account : Orleans.Grain<AccountState>, IAccount
    {
        private readonly ILogger logger;

        public Account(ILogger<Account> _logger)
        {
            this.logger = _logger;
        }

        public async Task<string> Debit(double amount)
        {
            await ReadStateAsync();
            State.AccountBalance -= amount;
            await WriteStateAsync();
            logger.LogInformation($"Amount of '{amount}' debited from account with Guid - {this.GetPrimaryKey()}");
            return "success";
        }

        public async Task<string> Credit(double amount)
        {
            await ReadStateAsync();
            State.AccountBalance += amount;
            await WriteStateAsync();
            logger.LogInformation($"Amount of '{amount}' credited to account with Guid - {this.GetPrimaryKey()}");
            return "success";
        }

        public async Task<double> GetBalance()
        {
            await ReadStateAsync();
            return State.AccountBalance;
        }
    }
}
