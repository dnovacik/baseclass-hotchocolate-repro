using BaseClassRepro.Entities.Block;
using HotChocolate.Types;
using static BaseClassRepro.Types.EnumTypes;

namespace BaseClassRepro.Types.Input.Block
{
    public sealed class DividerBlockInputType : InputObjectType<DividerBlock>
    {
        protected override void Configure(IInputObjectTypeDescriptor<DividerBlock> descriptor)
        {
            descriptor
                .Name(nameof(DividerBlockInputType));

            descriptor
                .Field(f => f.DividerType)
                .Type<DividerTypeEnumType>();

            descriptor
                .Field(f => f.DividerLength)
                .Type<DividerLengthEnumType>();
        }
    }
}
