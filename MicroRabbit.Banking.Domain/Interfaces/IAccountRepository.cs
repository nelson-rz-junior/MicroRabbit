﻿using MicroRabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccounts();

        Task<bool> ProcessTransferAsync(int from, int to, decimal amount);
    }
}
