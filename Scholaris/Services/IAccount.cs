using Scholaris.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scholaris.Services
{
    interface IAccount
    {
        IEnumerable<Account> GetAccounts { get; }
        Account GetAccount(int? Id);
        void Add(Account _Account);
        void Remove(int? Id);

    }
}
