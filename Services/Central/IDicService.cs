using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreAPI.Services.Central
{
    interface IDicService
    {
        Task<String> getById(int id);
    }
}
