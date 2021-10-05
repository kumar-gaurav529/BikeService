using Microsoft.EntityFrameworkCore;
using BikeService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BikeService.Models;

namespace BikeService.Services
{
    public class LogService : ILogService
    {
        #region variables
        private readonly BikeServiceContext context;
        #endregion

        #region constructor

        public LogService(BikeServiceContext _context)
        {
            context = _context;
        }
        #endregion


        #region methods
        public void WriteLog(Exception exception)
        {
            try
            {

                //detaching all entries from context...
                var changedEntriesCopy = context.ChangeTracker.Entries()
                                        .Where(e => e.State == EntityState.Added ||
                                        e.State == EntityState.Modified ||
                                        e.State == EntityState.Deleted).ToList();

                foreach (var entry in changedEntriesCopy)
                    entry.State = EntityState.Detached;



                var log = new TblLog
                {
                    ExceptionMessage = exception.Message.ToString(),
                    ExceptionType = exception.GetType().ToString(),
                    ExceptionSource = exception.StackTrace.ToString(),
                    LogDate = DateTime.Now
                };

                context.TblLogs.Add(log);
                context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        #endregion




    }
}
