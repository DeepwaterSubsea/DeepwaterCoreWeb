using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.StatusInfo
{
    public class ListStatusInformation
    {
        public class Query : IRequest<List<StatusInformation>> { }

        public class Handler : IRequestHandler<Query, List<StatusInformation>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<StatusInformation>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.StatusInformation.ToListAsync(cancellationToken: cancellationToken);
            }
        }
    }
}