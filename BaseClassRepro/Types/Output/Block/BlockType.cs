using BaseClassRepro.Entities.Block;
using HotChocolate.Types;
using static BaseClassRepro.Types.EnumTypes;

namespace BaseClassRepro.Types.Output.Block
{
    public sealed class BlockType : InterfaceType<IBlock>
    {
        protected override void Configure(IInterfaceTypeDescriptor<IBlock> descriptor)
        {
            descriptor
                .Name(nameof(BlockType));

            descriptor
                .Field(f => f.Id)
                .Type<NonNullType<UuidType>>();

            descriptor
                .Field(f => f.Type)
                .Type<BlockTypeEnumType>();
        }
    }
}
