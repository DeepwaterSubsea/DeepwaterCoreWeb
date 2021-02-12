using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.StatusInfo
{
    public class DetailsStatusInformation
    {
        public class Query : IRequest<StatusInformation>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, StatusInformation>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<StatusInformation> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.StatusInformation.FindAsync(request.Id);
            }
        }
    }
}