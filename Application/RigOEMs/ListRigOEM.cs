using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.RigOEMs
{
    public class ListRigOEM
    {
        public class Query : IRequest<List<RigOriginalEquipmentManufacturer>> { }

        public class Handler : IRequestHandler<Query, List<RigOriginalEquipmentManufacturer>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<RigOriginalEquipmentManufacturer>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.RigOEMs.ToListAsync(cancellationToken: cancellationToken);
            }
        }
    }
}