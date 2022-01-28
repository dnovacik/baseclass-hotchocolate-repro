using BaseClassRepro.Entities.Text;
using HotChocolate.Types;
using static BaseClassRepro.Types.EnumTypes;

namespace BaseClassRepro.Types.Output.Text
{
    public sealed class TextContentValueType : ObjectType<TextContentValue>
    {
        protected override void Configure(IObjectTypeDescriptor<TextContentValue> descriptor)
        {
            descriptor
                .Name(nameof(TextContentValueType));

            descriptor
                .Field(f => f.Id)
                .Type<NonNullType<UuidType>>();

            descriptor
                .Field(f => f.Type)
                .Type<TextTypeEnumType>();

            descriptor
                .Field(f => f.Text)
                .Type<StringType>();
        }
    }
}
