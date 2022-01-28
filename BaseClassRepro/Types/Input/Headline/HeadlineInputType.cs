using HotChocolate.Types;

namespace BaseClassRepro.Types.Input.Headline
{
    public class HeadlineInputType : InputObjectType<Entities.Headline.Headline>
    {
        protected override void Configure(IInputObjectTypeDescriptor<Entities.Headline.Headline> descriptor)
        {
            descriptor
                .Name(nameof(HeadlineInputType));

            descriptor
                .Field(f => f.Value)
                .Type<StringType>();
        }
    }
}
