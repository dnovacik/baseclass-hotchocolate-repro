using BaseClassRepro.Types.Input;
using BaseClassRepro.Types.Output;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseClassRepro.Mutation
{
    public class MutationType : ObjectType<Mutation>
    {
        protected override void Configure(IObjectTypeDescriptor<Mutation> descriptor)
        {
            descriptor
                .Field(f => f.AddPage(default!, default!))
                .Argument("page", a => a.Type<NonNullType<PageInputType>>())
                //.Resolve(ctx =>
                //{
                //    // resolve here?
                //})
                .Type<PageType>()
                .Name("addPage");
        }
    }
}
