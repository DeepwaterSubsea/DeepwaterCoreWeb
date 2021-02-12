using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.RigWellOperatorRecords
{
    public class ListRigWellOperatorRecord
    {
        public class Query : IRequest<List<RigWellOperatorRecord>> { }

        public class Handler : IRequestHandler<Query, List<RigWellOperatorRecord>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<RigWellOperatorRecord>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.RigWellOperatorRecords.ToListAsync(cancellationToken: cancellationToken);
            }
        }
    }
}