using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Portfolio.Persistence.Core;

namespace Portfolio.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;

        public UnitOfWork(ApplicationDbContext context)
        {
            _dbContext = context;
        }
        public void Complete()
        {
            _dbContext.SaveChanges();
        }
    }
}