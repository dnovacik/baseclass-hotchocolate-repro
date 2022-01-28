using BaseClassRepro.Entities;
using HotChocolate.Types;

namespace BaseClassRepro.Types
{
    public static class EnumTypes
    {
        public sealed class BlockTypeEnumType : EnumType<Enums.BlockType>
        {
            protected override void Configure(IEnumTypeDescriptor<Enums.BlockType> descriptor)
            {
                descriptor
                    .Name(nameof(BlockTypeEnumType));

                descriptor.BindValuesImplicitly();
            }
        }

        public sealed class TextTypeEnumType : EnumType<Enums.TextType>
        {
            protected override void Configure(IEnumTypeDescriptor<Enums.TextType> descriptor)
            {
                descriptor
                    .Name(nameof(TextTypeEnumType));

                descriptor.BindValuesImplicitly();
            }
        }

        public sealed class DividerTypeEnumType : EnumType<Enums.DividerType>
        {
            protected override void Configure(IEnumTypeDescriptor<Enums.DividerType> descriptor)
            {
                descriptor
                    .Name(nameof(DividerTypeEnumType));

                descriptor.BindValuesImplicitly();
            }
        }

        public sealed class DividerLengthEnumType : EnumType<Enums.DividerLength>
        {
            protected override void Configure(IEnumTypeDescriptor<Enums.DividerLength> descriptor)
            {
                descriptor
                    .Name(nameof(DividerLengthEnumType));

                descriptor.BindValuesImplicitly();
            }
        }
    }
}
