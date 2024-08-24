using CleanArchitecture.Application.Features.CarFeatures.Commands.CreateCar;
using CleanArchitecture.Domain.Dtos;
using MediatR;
using Moq;

namespace CleanArchitecture.UnitTest
{
    public class CarsControllerUnitTest
    {
        [Fact]
        public void Create_ReturnOkResult_WhenRequestIsValid()
        {
            // Arrange-tanimlama
            var mediatorMock = new Mock<IMediator>();
            CreateCarCommand createCarCommand = new(
               "Toyota","Corolla",5000);
            MessageResponse response = new("Arac basariyla kaydedildi!");
            CancellationToken cancellationToken = new();
            // Act-eylem

            //Assert-kontrolu yapariz
        }
    }
}