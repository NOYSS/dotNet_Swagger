using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebCoreAPI.Services.Central
{
    public class DicService : IDicService
    {
        private static readonly HttpClient HttpClient = new HttpClient();
        private RestHttpService restHttpService;

        public DicService() {
            this.restHttpService = new RestHttpService(HttpClient);
        }     

        public async Task<String> getById(int id)
        {
            String param = "" + id;
            return await this.restHttpService.GetAsync(param);
        }
    }
}
