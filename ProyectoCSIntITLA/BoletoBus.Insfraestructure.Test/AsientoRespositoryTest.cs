using BoletoBus.Domain.Entities;
using BoletoBus.Domain.Interfaces;
using BoletoBus.Domain.Models;
using BoletoBus.Infraestructure.Context;
using BoletoBus.Infraestructure.Repository;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace BoletoBus.Insfraestructure.Test
{

    public class AsientoRespositoryTest
    {
        private BusTicketContext context = null;
        private IAsientoRepository asientoRepository;


        public AsientoRespositoryTest()
        {
            var options = new DbContextOptionsBuilder<BusTicketContext>().UseInMemoryDatabase("Bus").Options;

            context = new BusTicketContext(options);

            asientoRepository = new AsientoRepository(context);

            List<Asiento> asientos = new List<Asiento>()
            {
                new Asiento()
                {
                    IdAsiento = 1,
                    IdBus = 1,
                    NumeroAsiento = 1,
                    NumeroPiso = 1,
                    FechaCreacion = DateTime.Now,
                    CreacionUsuario =  "admin"

                },
                   new Asiento()
                {
                    IdAsiento = 2,
                    IdBus = 2,
                    NumeroAsiento = 1,
                    NumeroPiso = 1,
                    FechaCreacion = DateTime.Now,
                    CreacionUsuario =  "admin"

                }
            };

            this.asientoRepository.Save(asientos);

        }

        [Fact]
        public void GetAsientos_WithValidAsientoModel()
        {
            //Arrange 
            var asientos = this.asientoRepository.GetAsientos();


            //Expect
            var asientoId = 1;

            //Assert
            Assert.NotNull(asientos);
            Assert.IsType<List<AsientoModel>>(asientos);
            Assert.True(asientos.Any());
            Assert.Equal(asientoId, asientos[0].IdAsiento);
        }

        [Fact]
        public async Task Get_InvalidAsientoId_ThrowsException()
        {
            // Arrange
            var invalidId = 99;

            // Act & Assert
            await Assert.ThrowsAsync<KeyNotFoundException>(async () => await asientoRepository.GetAsientoByIdAsync(invalidId));
        }

        [Fact]
        public async Task Get_ValidAsientoId_ReturnsAsiento()
        {
            // Arrange
            var validId = 1;

            // Act
            var asiento = await asientoRepository.GetAsientoByIdAsync(validId);

            // Assert
            Assert.NotNull(asiento);
            Assert.Equal(validId, asiento.IdAsiento);
        }

        [Fact]
        public void GetAsientos_ReturnsListOfAsiento()
        {
            // Act
            var asientos = this.asientoRepository.GetAsientos();

            // Assert
            Assert.NotNull(asientos);
            Assert.IsType<List<AsientoModel>>(asientos);
            Assert.True(asientos.Count > 0);
        }

    }
}