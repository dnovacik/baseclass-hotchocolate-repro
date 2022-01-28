using BaseClassRepro.Entities;
using HotChocolate.Resolvers;
using System.Threading.Tasks;

namespace BaseClassRepro.Mutation
{
    public class Mutation
    {
        public Task<Page> AddPage(
            Page page,
            IResolverContext resolverContext)
        {
            // this would go into repository code
            return Task.FromResult<Page>(page);
        }
    }
}
