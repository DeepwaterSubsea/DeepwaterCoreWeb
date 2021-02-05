using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Persistence;

namespace Application.RigOperators
{
    public class Edit
    {
        public class Command : IRequest
        {
            public Guid Id { get; set; }

            [Required]
            public string Name { get; set; }
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
                var rigOperator = await _context.RigOperators.FindAsync(request.Id);

                if (rigOperator == null)
                    throw new Exception("Could not find the record");

                rigOperator.Name = request.Name ?? rigOperator.Name;

                var success = await _context.SaveChangesAsync(cancellationToken) > 0;

                if (success) return Unit.Value;
                throw new Exception("Problem saving changes");
            }
        }
    }
}
