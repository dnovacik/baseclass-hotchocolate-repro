using BaseClassRepro.Entities.Block;
using BaseClassRepro.Types.Input.Text;
using HotChocolate.Types;

namespace BaseClassRepro.Types.Input.Block
{
    public sealed class TextBlockContentInputType : InputObjectType<TextBlockContent>
    {
        protected override void Configure(IInputObjectTypeDescriptor<TextBlockContent> descriptor)
        {
            descriptor
                .Name(nameof(TextBlockContentInputType));

            descriptor
                .Field(f => f.Text)
                .Type<TextContentInputType>();
        }
    }
}
