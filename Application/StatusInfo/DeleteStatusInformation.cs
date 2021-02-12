using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Persistence;

namespace Application.StatusInfo
{
    public class DeleteStatusInformation
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
                var statusInformation = await _context.StatusInformation.FindAsync(request.Id);

                if (statusInformation == null)
                    throw new Exception("Cannot find the record");

                _context.StatusInformation.Remove(statusInformation);

                var success = await _context.SaveChangesAsync(cancellationToken) > 0;

                if (success) return Unit.Value;
                throw new Exception("Problem saving changes");
            }
        }
    }
}
