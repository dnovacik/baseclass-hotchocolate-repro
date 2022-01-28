using BaseClassRepro.Entities;
using HotChocolate.Types;
using static BaseClassRepro.Types.UnionTypes;

namespace BaseClassRepro.Types.Output
{
    public class PageType : ObjectType<Page>
    {
        protected override void Configure(IObjectTypeDescriptor<Page> descriptor)
        {
            descriptor
                .Name(nameof(PageType));

            descriptor
                .Field(f => f.Id)
                .Type<NonNullType<UuidType>>();

            descriptor
                .Field(f => f.Sections)
                .Type<NonNullType<ListType<SectionUnionType>>>();
        }
    }
}
