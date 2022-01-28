using BaseClassRepro.Entities.Section;
using BaseClassRepro.Types.Output.Headline;
using HotChocolate.Types;
using static BaseClassRepro.Types.UnionTypes;

namespace BaseClassRepro.Types.Output.Section
{
    public sealed class TextMediaSectionType : ObjectType<TextMediaSection>
    {
        protected override void Configure(IObjectTypeDescriptor<TextMediaSection> descriptor)
        {
            descriptor
                .Name(nameof(TextMediaSectionType));

            descriptor
                .Implements<SectionType>();

            descriptor
                .Field(f => f.Id)
                .Type<NonNullType<UuidType>>();

            descriptor
                .Field(f => f.Title)
                .Type<NonNullType<HeadlineType>>();

            descriptor
                .Field(f => f.Content)
                .Type<ListType<BlockUnionType>>();
        }
    }
}
