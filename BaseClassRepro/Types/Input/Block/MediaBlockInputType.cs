using BaseClassRepro.Entities.Block;
using BaseClassRepro.Types.Input.Media;
using HotChocolate.Types;

namespace BaseClassRepro.Types.Input.Block
{
    public sealed class MediaBlockInputType : InputObjectType<MediaBlock>
    {
        protected override void Configure(IInputObjectTypeDescriptor<MediaBlock> descriptor)
        {
            descriptor
                .Name(nameof(MediaBlockInputType));

            descriptor
                .Field(f => f.Content)
                .Type<MediaInputType>();
        }
    }
}
