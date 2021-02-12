using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Wells
{
    public class DetailsWell
    {
        public class Query : IRequest<Well>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Well>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Well> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Wells.FindAsync(request.Id);
            }
        }
    }
}