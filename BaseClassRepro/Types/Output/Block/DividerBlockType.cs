using BaseClassRepro.Entities.Block;
using HotChocolate.Types;
using static BaseClassRepro.Types.EnumTypes;

namespace BaseClassRepro.Types.Output.Block
{
    public sealed class DividerBlockType : ObjectType<DividerBlock>
    {
        protected override void Configure(IObjectTypeDescriptor<DividerBlock> descriptor)
        {
            descriptor
                .Name(nameof(DividerBlockType));

            descriptor
                .Field(f => f.Id)
                .Type<NonNullType<UuidType>>();

            descriptor
                .Field(f => f.DividerType)
                .Type<DividerTypeEnumType>();

            descriptor
                .Field(f => f.DividerLength)
                .Type<DividerLengthEnumType>();

            descriptor
                .Field(f => f.Type)
                .Type<BlockTypeEnumType>();
        }
    }
}
