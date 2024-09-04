using CleanArchitecture.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.CarFeatures.Queries.GetAllCar
{
    public sealed class GetAllCarQueryHandler : IRequestHandler<GetAllCarQuery, IList<Car>>
    {
        public Task<IList<Car>> Handle(GetAllCarQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
