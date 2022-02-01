using BaseClassRepro.Entities;
using BaseClassRepro.Entities.Section;
using BaseClassRepro.Types.Input;
using BaseClassRepro.Types.Output;
using HotChocolate.Resolvers;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseClassRepro.Mutation
{
    public class MutationType //: ObjectType<Mutation>
    {
        //protected override void Configure(IObjectTypeDescriptor<Mutation> descriptor)
        //{
        //    descriptor
        //        .Field(f => f.AddPage(default!, default!))
        //        .Argument("page", a => a.Type<NonNullType<PageInputType>>())
        //        //.Resolve(ctx =>
        //        //{
        //        //    // resolve here?
        //        //})
        //        .Type<PageType>()
        //        .Name("addPage");
        //}

        // this complaints The object type `MutationType` has to at least define one field in order to be valid. (HotChocolate.Types.ObjectType<BaseClassRepro.Mutation.MutationType>)
        // if I move this to the Mutation.cs and do the configure above, it complaints I can't use 'PageInput' as an Input type, not sure how to "extend it properly"
        public Task<Page> AddPage(
            PageInput input)
        {
            var page = new Page
            {
                Id = Guid.NewGuid(),
                Sections = input.Sections.Where(s => s.Value != null).Select(x => x.Value as Section).ToList()
            };

            // this would go into repository code
            return Task.FromResult<Page>(page);
        }
    }
}
