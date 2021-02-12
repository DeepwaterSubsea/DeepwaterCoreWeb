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

namespace Application.RigOperators
{
    public class EditRigOperator
    {
        public class Command : IRequest
        {
            public RigOperator RigOperator { get; set; }
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
                var rigOperator = await _context.RigOperators.FindAsync(request.RigOperator.Id);

                if (rigOperator == null)
                    throw new Exception("Could not find the record");

                // rigOperator.Name = request.Name ?? rigOperator.Name;
                _mapper.Map(request.RigOperator, rigOperator);

                var success = await _context.SaveChangesAsync(cancellationToken) > 0;

                if (success) return Unit.Value;
                throw new Exception("Problem saving changes");
            }
        }
    }
}
