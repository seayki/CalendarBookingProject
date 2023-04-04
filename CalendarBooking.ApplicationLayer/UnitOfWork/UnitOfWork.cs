using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace CalendarBooking.ApplicationLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable    
    {
        private DbContext _context { get; set; }
        private bool _disposed;
        private DbContextTransaction transaction;       
        private string errors = string.Empty;
        public UnitOfWork(DbContext context)
        {
            _context = context;
        }
     
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public DbContext Context
        {
            get { return _context; }
        }
        public void CreateTransaction()
        {
            transaction = _context.Database.BeginTransaction();
        }
    
        public void Commit()
        {
            transaction.Commit();
        }

        public void Rollback()
        {
            transaction.Rollback();
            transaction.Dispose();
        }
     
        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                Rollback();
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                    foreach (var validationError in validationErrors.ValidationErrors)
                        errors += string.Format("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage) + Environment.NewLine;
                throw new Exception(errors, dbEx);
               
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
