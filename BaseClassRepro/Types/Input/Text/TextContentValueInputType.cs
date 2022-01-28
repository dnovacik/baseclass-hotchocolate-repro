using BaseClassRepro.Entities.Text;
using HotChocolate.Types;
using static BaseClassRepro.Types.EnumTypes;

namespace BaseClassRepro.Types.Input.Text
{
    public sealed class TextContentValueInputType : InputObjectType<TextContentValue>
    {
        protected override void Configure(IInputObjectTypeDescriptor<TextContentValue> descriptor)
        {
            descriptor
                .Name(nameof(TextContentValueInputType));

            descriptor
                .Field(f => f.Type)
                .Type<TextTypeEnumType>();

            descriptor
                .Field(f => f.Text)
                .Type<StringType>();
        }
    }
}
