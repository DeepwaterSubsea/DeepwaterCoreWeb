using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.RigAssets
{
    public class List
    {
        public class Query : IRequest<List<RigAsset>> { }

        public class Handler : IRequestHandler<Query, List<RigAsset>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<RigAsset>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.RigAssets.ToListAsync();
            }
        }
    }
}