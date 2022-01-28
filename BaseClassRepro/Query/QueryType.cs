using BaseClassRepro.Types.Output;
using HotChocolate.Types;

namespace BaseClassRepro.Query
{
    public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor
                .Field(f => f.GetPage(default!))
                .Argument("id", a => a.Type<UuidType>())
                .Type<PageType>()
                .Name("page");
        }
    }
}
