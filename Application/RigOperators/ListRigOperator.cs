using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.RigOperators
{
    public class ListRigOperator
    {
        public class Query : IRequest<List<RigOperator>> { }

        public class Handler : IRequestHandler<Query, List<RigOperator>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<RigOperator>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.RigOperators.ToListAsync(cancellationToken: cancellationToken);
            }
        }
    }
}