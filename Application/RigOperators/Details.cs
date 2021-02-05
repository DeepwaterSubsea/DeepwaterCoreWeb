using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.RigOperators
{
    public class Details
    {
        public class Query : IRequest<RigOperator>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, RigOperator>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<RigOperator> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.RigOperators.FindAsync(request.Id);
            }
        }
    }
}