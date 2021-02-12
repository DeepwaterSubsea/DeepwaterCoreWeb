using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.RigAssets
{
    public class DetailsRigAsset
    {
        public class Query : IRequest<RigAsset>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, RigAsset>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<RigAsset> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.RigAssets.FindAsync(request.Id);
            }
        }
    }
}