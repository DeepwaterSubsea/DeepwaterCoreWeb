using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Rigs
{
    public class ListRig
    {
        public class Query : IRequest<List<Rig>> { }

        public class Handler : IRequestHandler<Query, List<Rig>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<Rig>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Rigs.Include(r => r.Contractor).ToListAsync(cancellationToken: cancellationToken);
            }
        }
    }
}