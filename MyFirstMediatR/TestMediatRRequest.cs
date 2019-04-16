using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MyFirstMediatR
{
    // When you send a request, one and only one handler 
    // will be called and will return a response of the appropriate type. 
    public class Ping : IRequest<string> { }
    public class PingHandler : IRequestHandler<Ping, string>
    {
        //public string Handle(Ping request)
        //{
        //    return "Pong";
        //}

        public Task<string> Handle(Ping request, CancellationToken cancellationToken)
        {
            return Task.FromResult("Pong");
        }
    }
    // optional to show what happens with multiple handlers
    public class Ping2Handler : IRequestHandler<Ping, string>
    {
        //public string Handle(Ping request)
        //{
        //    return "Pong2";
        //}

        public Task<string> Handle(Ping request, CancellationToken cancellationToken)
        {
            return Task.FromResult("Pong2");
        }
    }
}
