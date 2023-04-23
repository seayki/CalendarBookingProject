using CalendarBooking.ApplicationLayer.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalendarBooking.InfrastructureLayer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data;
using Microsoft.Identity.Client;

namespace CalendarBooking.InfrastructureLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private DBContext _context { get; set; }
        private bool _disposed;
        public UnitOfWork(DBContext context)
        {
            _context = context;
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        public DBContext Context
        {
            get { return _context; }
        }
        public void CreateTransaction()
        {
           _context.Database.BeginTransaction();
        }

        public void Commit()
        {
            _context.Database.CommitTransaction();

        }

        public void Rollback()
        {
            _context.Database.RollbackTransaction();
        }

        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DBConcurrencyException ex)
            {
                Rollback();
                throw new Exception("Unable to save due to concurrency conflict");
            }

        }
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
                if (disposing)
                    _context.Dispose();
            _disposed = true;
        }
    }
}
