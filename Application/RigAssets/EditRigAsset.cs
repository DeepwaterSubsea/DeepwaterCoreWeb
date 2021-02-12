using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
using MediatR;
using Persistence;

namespace Application.RigAssets
{
    public class EditRigAsset
    {
        public class Command : IRequest
        {
            public RigAsset RigAsset { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            private readonly IMapper _mapper;
            public Handler(DataContext context, IMapper mapper)
            {
                _mapper = mapper;
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var rigAsset = await _context.RigAssets.FindAsync(request.RigAsset.Id);

                if (rigAsset == null)
                    throw new Exception("Could not find the record");

                _mapper.Map(request.RigAsset, rigAsset);

                var success = await _context.SaveChangesAsync(cancellationToken) > 0;

                if (success) return Unit.Value;
                throw new Exception("Problem saving changes");
            }
        }
    }
}
