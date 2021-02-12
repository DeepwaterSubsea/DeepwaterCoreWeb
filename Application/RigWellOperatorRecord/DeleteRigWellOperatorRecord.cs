using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Persistence;

namespace Application.RigWellOperatorRecords
{
    public class DeleteRigWellOperatorRecord
    {
        public class Command : IRequest
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var rigWellOperatorRecord = await _context.RigWellOperatorRecords.FindAsync(request.Id);

                if (rigWellOperatorRecord == null)
                    throw new Exception("Cannot find the record");

                _context.RigWellOperatorRecords.Remove(rigWellOperatorRecord);

                var success = await _context.SaveChangesAsync(cancellationToken) > 0;

                if (success) return Unit.Value;
                throw new Exception("Problem saving changes");
            }
        }
    }
}
