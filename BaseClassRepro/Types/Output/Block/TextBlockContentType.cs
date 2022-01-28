using BaseClassRepro.Entities.Block;
using BaseClassRepro.Types.Output.Text;
using HotChocolate.Types;

namespace BaseClassRepro.Types.Output.Block
{
    public sealed class TextBlockContentType : ObjectType<TextBlockContent>
    {
        protected override void Configure(IObjectTypeDescriptor<TextBlockContent> descriptor)
        {
            descriptor
                .Name(nameof(TextBlockContentType));

            descriptor
                .Field(f => f.Id)
                .Type<NonNullType<UuidType>>();

            descriptor
                .Field(f => f.Text)
                .Type<TextContentType>();
        }
    }
}
