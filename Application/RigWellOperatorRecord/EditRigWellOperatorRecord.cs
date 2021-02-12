using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
using MediatR;
using Persistence;

namespace Application.RigWellOperatorRecords
{
    public class EditRigWellOperatorRecord
    {
        public class Command : IRequest
        {
            public RigWellOperatorRecord RigWellOperatorRecord { get; set; }
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
                var rigWellOperatorRecord = await _context.RigWellOperatorRecords.FindAsync(request.RigWellOperatorRecord.Id);

                if (rigWellOperatorRecord == null)
                    throw new Exception("Could not find the record");

                _mapper.Map(request.RigWellOperatorRecord, rigWellOperatorRecord);

                var success = await _context.SaveChangesAsync(cancellationToken) > 0;

                if (success) return Unit.Value;
                throw new Exception("Problem saving changes");
            }
        }
    }
}
