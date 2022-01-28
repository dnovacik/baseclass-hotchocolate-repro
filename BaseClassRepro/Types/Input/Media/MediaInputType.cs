using HotChocolate.Types;

namespace BaseClassRepro.Types.Input.Media
{
    public class MediaInputType : InputObjectType<Entities.Media.Media>
    {
        protected override void Configure(IInputObjectTypeDescriptor<Entities.Media.Media> descriptor)
        {
            descriptor
                .Name(nameof(MediaInputType));

            descriptor
                .Field(f => f.Url)
                .Type<NonNullType<StringType>>();
        }
    }
}
