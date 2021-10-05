using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeService.Interfaces
{
    public interface ILogService
    {
        void WriteLog(Exception exception);

    }
}
