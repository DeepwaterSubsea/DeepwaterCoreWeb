using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
using MediatR;
using Persistence;

namespace Application.RigContractors
{
    public class EditRigContractor
    {
        public class Command : IRequest
        {
            public RigContractor RigContractor { get; set; }
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
                var rigContractor = await _context.RigContractors.FindAsync(request.RigContractor.Id);

                if (rigContractor == null)
                    throw new Exception("Could not find the record");

                _mapper.Map(request.RigContractor, rigContractor);

                var success = await _context.SaveChangesAsync(cancellationToken) > 0;

                if (success) return Unit.Value;
                throw new Exception("Problem saving changes");
            }
        }
    }
}
