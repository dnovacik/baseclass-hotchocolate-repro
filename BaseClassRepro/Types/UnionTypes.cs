using BaseClassRepro.Types.Output.Block;
using BaseClassRepro.Types.Output.Section;
using HotChocolate.Types;

namespace BaseClassRepro.Types
{
    public class UnionTypes
    {
        public sealed class SectionUnionType : UnionType
        {
            protected override void Configure(IUnionTypeDescriptor descriptor)
            {
                descriptor
                    .Name(nameof(SectionUnionType));

                descriptor
                    .Type<MediaSectionType>()
                    .Type<TextMediaSectionType>();
            }
        }

        public sealed class BlockUnionType : UnionType
        {
            protected override void Configure(IUnionTypeDescriptor descriptor)
            {
                descriptor
                    .Name(nameof(BlockUnionType));

                descriptor
                    .Type<DividerBlockType>()
                    .Type<TextBlockType>()
                    .Type<MediaBlockType>();
            }
        }
    }
}
