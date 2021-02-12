using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.RigContractors
{
    public class DetailsRigContractor
    {
        public class Query : IRequest<RigContractor>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, RigContractor>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<RigContractor> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.RigContractors.FindAsync(request.Id);
            }
        }
    }
}