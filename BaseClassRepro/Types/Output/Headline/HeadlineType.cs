using HotChocolate.Types;

namespace BaseClassRepro.Types.Output.Headline
{
    public class HeadlineType : ObjectType<Entities.Headline.Headline>
    {
        protected override void Configure(IObjectTypeDescriptor<Entities.Headline.Headline> descriptor)
        {
            descriptor
                .Name(nameof(HeadlineType));

            descriptor
                .Field(f => f.Id)
                .Type<NonNullType<UuidType>>();


            descriptor
                .Field(f => f.Value)
                .Type<NonNullType<StringType>>();
        }
    }
}
