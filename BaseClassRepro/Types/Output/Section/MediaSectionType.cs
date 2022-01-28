using BaseClassRepro.Entities.Section;
using BaseClassRepro.Types.Output.Block;
using BaseClassRepro.Types.Output.Headline;
using HotChocolate.Types;

namespace BaseClassRepro.Types.Output.Section
{
    public class MediaSectionType : ObjectType<MediaSection>
    {
        protected override void Configure(IObjectTypeDescriptor<MediaSection> descriptor)
        {
            descriptor
                .Name(nameof(MediaSectionType));

            descriptor
                .Field(f => f.Id)
                .Type<NonNullType<UuidType>>();

            descriptor
                .Field(f => f.Title)
                .Type<NonNullType<HeadlineType>>();

            descriptor
                .Field(f => f.Content)
                .Type<NonNullType<MediaBlockType>>();

            descriptor
                .Implements<SectionType>();
        }
    }
}
