using BaseClassRepro.Entities.Text;
using HotChocolate.Types;

namespace BaseClassRepro.Types.Output.Text
{
    public sealed class TextContentType : ObjectType<TextContent>
    {
        protected override void Configure(IObjectTypeDescriptor<TextContent> descriptor)
        {
            descriptor
                .Name(nameof(TextContentType));

            descriptor
                .Field(f => f.Id)
                .Type<NonNullType<UuidType>>();


            descriptor
                .Field(f => f.TextContentValue)
                .Type<NonNullType<TextContentValueType>>();
        }
    }
}
