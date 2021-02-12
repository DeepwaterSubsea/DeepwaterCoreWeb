using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.RigOEMs
{
    public class DetailsRigOEM
    {
        public class Query : IRequest<RigOriginalEquipmentManufacturer>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, RigOriginalEquipmentManufacturer>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<RigOriginalEquipmentManufacturer> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.RigOEMs.FindAsync(request.Id);
            }
        }
    }
}