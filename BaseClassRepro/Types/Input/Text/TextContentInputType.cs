using BaseClassRepro.Entities.Text;
using HotChocolate.Types;

namespace BaseClassRepro.Types.Input.Text
{
    public class TextContentInputType : InputObjectType<TextContent>
    {
        protected override void Configure(IInputObjectTypeDescriptor<TextContent> descriptor)
        {
            descriptor
                .Name(nameof(TextContentInputType));

            descriptor
                .Field(f => f.TextContentValue)
                .Type<TextContentValueInputType>();
        }
    }
}
