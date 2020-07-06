using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreAPI.Services
{
    interface IRestHttpService
    {
        Task<String> GetAsync(int id);

        Task<String> PostAsync(String dataJson);

        Task<String> PutAsync(int id, String dataJson);

        Task<String> DeleteAsync(int id);
    }
}
