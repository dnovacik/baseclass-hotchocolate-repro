using BaseClassRepro.Entities.Section;
using HotChocolate.Types;

namespace BaseClassRepro.Types.Output.Section
{
    public class SectionType : InterfaceType<ISection>
    {
        protected override void Configure(IInterfaceTypeDescriptor<ISection> descriptor)
        {
            descriptor
                .Name(nameof(SectionType));

            descriptor
                .Field(f => f.Id)
                .Type<NonNullType<UuidType>>();
        }
    }
}
