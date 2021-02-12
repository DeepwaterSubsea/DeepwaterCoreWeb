using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Rigs
{
    public class DetailsRig
    {
        public class Query : IRequest<Rig>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Rig>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Rig> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Rigs.FindAsync(request.Id);
            }
        }
    }
}