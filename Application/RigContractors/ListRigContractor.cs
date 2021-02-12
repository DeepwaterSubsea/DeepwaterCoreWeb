using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.RigContractors
{
    public class ListRigContractor
    {
        public class Query : IRequest<List<RigContractor>> { }

        public class Handler : IRequestHandler<Query, List<RigContractor>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<RigContractor>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.RigContractors.ToListAsync(cancellationToken: cancellationToken);
            }
        }
    }
}