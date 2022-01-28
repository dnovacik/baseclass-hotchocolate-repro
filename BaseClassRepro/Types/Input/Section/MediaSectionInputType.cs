using BaseClassRepro.Entities.Section;
using BaseClassRepro.Types.Input.Block;
using BaseClassRepro.Types.Input.Headline;
using HotChocolate.Types;

namespace BaseClassRepro.Types.Input.Section
{
    public class MediaSectionInputType : InputObjectType<MediaSection>
    {
        protected override void Configure(IInputObjectTypeDescriptor<MediaSection> descriptor)
        {
            descriptor
                .Name(nameof(MediaSectionInputType));

            descriptor
                .Field(f => f.Title)
                .Type<HeadlineInputType>();

            descriptor
                .Field(f => f.Content)
                .Type<MediaBlockInputType>();
        }
    }
}
