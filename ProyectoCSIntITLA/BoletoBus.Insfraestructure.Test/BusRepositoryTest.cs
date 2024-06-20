using BoletoBus.Domain.Entities;
using BoletoBus.Domain.Interfaces;
using BoletoBus.Domain.Models;
using BoletoBus.Infraestructure.Context;
using BoletoBus.Infraestructure.Repository;
using Microsoft.EntityFrameworkCore;


namespace BoletoBus.Insfraestructure.Test
{
    public class BusRepositoryTest
    {
        private BusTicketContext context = null;
        private IBusRepository busRepository;

        public BusRepositoryTest()
        {
            var options = new DbContextOptionsBuilder<BusTicketContext>().UseInMemoryDatabase("Ticket").Options;

            context = new BusTicketContext(options);

            busRepository = new BusRepository(context);

            List<Bus> bus = new List<Bus>()
            {
                new Bus()
                {
                    IdBus = 1,
                    NumeroPlaca = "ABC123",
                    Nombre = "Bus A",
                    Disponible = true,
                    FechaCreacion = DateTime.Now,
                    CreacionUsuario =  "admin"
                },
                 new Bus()
                {
                    IdBus = 2,
                    NumeroPlaca = "ABC456",
                    Nombre = "Bus B",
                    Disponible = true,
                    FechaCreacion = DateTime.Now,
                    CreacionUsuario =  "admin"
                }
            };
        }

        [Fact]
        public void GetBus_WithValidBusModel()
        {
            //Arrange 
            var bus = this.busRepository.GetBus();


            //Expect
            var busId = 1;

            //Assert
            Assert.NotNull(bus);
            Assert.IsType<List<BusModel>>(bus);
            Assert.True(bus.Any());
            Assert.Equal(busId, bus[0].IdBus);
        }

        [Fact]
        public async Task Get_InvalidBusId_ThrowsException()
        {
            // Arrange
            var invalidId = 99;

            // Act & Assert
            await Assert.ThrowsAsync<KeyNotFoundException>(async () => await busRepository.GetBusByIdAsync(invalidId));
        }
        [Fact]
        public async Task Get_ValidBusId_ReturnsBus()
        {
            // Arrange
            var validId = 1;

            // Act
            var bus = await busRepository.GetBusByIdAsync(validId);

            // Assert
            Assert.NotNull(bus);
            Assert.Equal(validId, bus.IdBus);
        }
        [Fact]
        public void GetBus_ReturnsListOfBus()
        {
            // Act
            var bus = this.busRepository.GetBus();

            // Assert
            Assert.NotNull(bus);
            Assert.IsType<List<BusModel>>(bus);
            Assert.True(bus.Count > 0);
        }


    }
}

