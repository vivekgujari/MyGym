﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Data.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
