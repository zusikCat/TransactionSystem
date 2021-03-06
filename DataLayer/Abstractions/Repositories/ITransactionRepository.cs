﻿using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Abstractions.Repositories
{
    public interface ITransactionRepository : IRepository<Transaction>
    {
        int GetCountOfRecords();
        Task<Transaction> GetByTransactionId(int id);
    }
}
