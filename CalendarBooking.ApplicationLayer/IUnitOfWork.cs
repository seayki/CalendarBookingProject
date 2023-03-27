 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.ApplicationLayer {
    public interface IUnitOfWork 
    {
    
            using var transaction = _dbcontext.Database.
            BeginTransaction(IsolationLevel.Serializable);
    
      await transaction.CommitAsync();
        catch (Exception e)
            {
                Console.WriteLine(e);
                transaction.Rollback();
               
            }
}
    
}
