using BaseClassRepro.Entities;
using BaseClassRepro.Types.Input.Section;
using HotChocolate.Types;

namespace BaseClassRepro.Types.Input
{
    public class PageInputType : InputObjectType<Page>
    {
        protected override void Configure(IInputObjectTypeDescriptor<Page> descriptor)
        {
            descriptor
                .Name(nameof(PageInputType));

            descriptor
                .Field(f => f.Sections)
                .Type<NonNullType<ListType<SectionInputType>>>();
        }
    }
}
