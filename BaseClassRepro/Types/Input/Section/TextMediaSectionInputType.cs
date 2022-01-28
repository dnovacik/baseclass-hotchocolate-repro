using BaseClassRepro.Entities.Section;
using BaseClassRepro.Types.Input.Block;
using BaseClassRepro.Types.Input.Headline;
using HotChocolate.Types;

namespace BaseClassRepro.Types.Input.Section
{
    public sealed class TextMediaSectionInputType : InputObjectType<TextMediaSection>
    {
        protected override void Configure(IInputObjectTypeDescriptor<TextMediaSection> descriptor)
        {
            descriptor
                .Name(nameof(TextMediaSectionInputType));

            descriptor
                .Field(f => f.Title)
                .Type<HeadlineInputType>();

            descriptor
                .Field(f => f.Content)
                .Type<ListType<BlockInputType>>();
        }
    }
}
