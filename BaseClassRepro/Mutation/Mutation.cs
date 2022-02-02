using BaseClassRepro.Entities;
using BaseClassRepro.Entities.Block;
using BaseClassRepro.Entities.Section;
using HotChocolate.Resolvers;
using System.Linq;
using System.Threading.Tasks;

namespace BaseClassRepro.Mutation
{
    public class Mutation
    {
        public Task<Page> AddPage(
            Page page,
            IResolverContext resolverContext)
        {
            MapGQLSectionsAndBlocks(page);

            // this would go into repository code
            return Task.FromResult<Page>(page);
        }

        private void MapGQLSectionsAndBlocks(Page page)
        {
            page.Sections = page.SectionsGQL
                .Select(s =>
                {
                    if (s.Value is MediaSection)
                    {
                        return s.Value;
                    }
                    else
                    {
                        var textSection = s.Value as TextMediaSection;

                        textSection.Content = textSection.ContentGQL
                            .Select(b =>
                            {
                                return b.Value as Block;
                            }).ToList();

                        return textSection;
                    }
                }).ToList();
        }
    }
}
