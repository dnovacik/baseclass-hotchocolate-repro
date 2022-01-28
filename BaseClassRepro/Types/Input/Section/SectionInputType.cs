using HotChocolate.Types;

namespace BaseClassRepro.Types.Input.Section
{
    public class SectionInputType : InputObjectType
    {
        protected override void Configure(IInputObjectTypeDescriptor descriptor)
        {
            descriptor
                .Name(nameof(SectionInputType))
                .OneOf();

            descriptor
                .Field("media")
                .Type<MediaSectionInputType>();

            descriptor
                .Field("textMedia")
                .Type<TextMediaSectionInputType>();
        }
    }
}
