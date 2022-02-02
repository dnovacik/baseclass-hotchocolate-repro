using BaseClassRepro.Entities.Section;
using HotChocolate.Types;

namespace BaseClassRepro.Types.Output.Section
{
    public class SectionType : InterfaceType<Entities.Section.Section>
    {
        protected override void Configure(IInterfaceTypeDescriptor<Entities.Section.Section> descriptor)
        {
            descriptor
                .Name(nameof(SectionType));

            descriptor
                .Field(f => f.Id)
                .Type<NonNullType<UuidType>>();
        }
    }
}
