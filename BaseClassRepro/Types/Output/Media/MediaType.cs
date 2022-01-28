using HotChocolate.Types;

namespace BaseClassRepro.Types.Output.Media
{
    public class MediaType : ObjectType<Entities.Media.Media>
    {
        protected override void Configure(IObjectTypeDescriptor<Entities.Media.Media> descriptor)
        {
            descriptor
                .Name(nameof(MediaType));

            descriptor
                .Field(f => f.Url)
                .Type<NonNullType<StringType>>();
        }
    }
}
