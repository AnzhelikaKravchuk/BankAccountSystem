﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Core.Interfaces
{
    public interface IRepository : IDisposable
    {
        Dictionary<string, Account> Accounts { get; set; }

        void Create(Account account);
        void Save();
        void Update(string id);
        Dictionary<string, Account> Read();
        Account GetByNumber(string id);
    }
}
