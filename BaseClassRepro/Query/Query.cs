using BaseClassRepro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseClassRepro.Query
{
    public class Query
    {
        public async Task<Page> GetPage(Guid id)
        {
            return await Task.FromResult<Page>(new Page());
        }
    }
}
