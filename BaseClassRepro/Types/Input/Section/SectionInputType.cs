using BaseClassRepro.Entities.Section;
using HotChocolate.Types;

namespace BaseClassRepro.Types.Input.Section
{
    public class SectionInputType : InputObjectType<SectionInput>
    {
        protected override void Configure(IInputObjectTypeDescriptor<SectionInput> descriptor)
        {
            descriptor
                .Name(nameof(SectionInputType))
                .OneOf();

            descriptor
                .Ignore(f => f.Value);

            descriptor
                .Field(f => f.Media)
                .Type<MediaSectionInputType>();

            descriptor
                .Field(f => f.TextMedia)
                .Type<TextMediaSectionInputType>();
        }
    }

#nullable enable
    public class SectionInput
    {
        public MediaSection? Media { get; set; }
        public TextMediaSection? TextMedia { get; set; }

        public Entities.Section.Section Value => Media != null ? Media : TextMedia;
    }
#nullable disable


}
