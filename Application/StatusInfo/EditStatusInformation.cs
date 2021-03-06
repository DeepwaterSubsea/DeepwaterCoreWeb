﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
using MediatR;
using Persistence;

namespace Application.StatusInfo
{
    public class EditStatusInformation
    {
        public class Command : IRequest
        {
            public StatusInformation StatusInformation { get; set; }
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
                var statusInformation = await _context.StatusInformation.FindAsync(request.StatusInformation.Id);

                if (statusInformation == null)
                    throw new Exception("Could not find the record");

                _mapper.Map(request.StatusInformation, statusInformation);

                var success = await _context.SaveChangesAsync(cancellationToken) > 0;

                if (success) return Unit.Value;
                throw new Exception("Problem saving changes");
            }
        }
    }
}
