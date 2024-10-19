using CleanArchitecture.Domain.Dtos;
using MediatR;

namespace CleanArchitecture.Application.Features.AuthFeatures.Commands.Register
{
    public sealed class RegisterCommandHandler : IRequestHandler<RegisterCommand, MessageResponse>
    {
        public Task<MessageResponse> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
