using BaseClassRepro.Entities.Block;
using HotChocolate.Types;

namespace BaseClassRepro.Types.Input.Block
{
    public sealed class TextBlockInputType : InputObjectType<TextBlock>
    {
        protected override void Configure(IInputObjectTypeDescriptor<TextBlock> descriptor)
        {
            descriptor
                .Name(nameof(TextBlockInputType));

            descriptor
                .Field(f => f.Content)
                .Type<ListType<TextBlockContentInputType>>();
        }
    }
}
