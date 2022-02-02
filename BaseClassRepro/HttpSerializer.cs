using HotChocolate.AspNetCore.Serialization;
using HotChocolate.Execution;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace BaseClassRepro
{
    public class HttpSerializerExtension : DefaultHttpResultSerializer
    {
        public override HttpStatusCode GetStatusCode(IExecutionResult result)
        {
            return base.GetStatusCode(result);
        }

        public override ValueTask SerializeAsync(IExecutionResult result, Stream stream, CancellationToken cancellationToken)
        {
            return base.SerializeAsync(result, stream, cancellationToken);
        }

        public override string GetContentType(IExecutionResult result)
        {
            return base.GetContentType(result);
        }
    }
}
