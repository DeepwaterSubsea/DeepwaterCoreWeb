using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Wells
{
    public class ListWell
    {
        public class Query : IRequest<List<Well>> { }

        public class Handler : IRequestHandler<Query, List<Well>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<Well>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Wells.ToListAsync(cancellationToken: cancellationToken);
            }
        }
    }
}