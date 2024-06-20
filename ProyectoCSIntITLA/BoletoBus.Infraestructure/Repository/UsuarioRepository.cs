

using BoletoBus.Domain.Entities;
using BoletoBus.Domain.Interfaces;
using BoletoBus.Infraestructure.Context;
using BoletoBus.Infraestructure.Core;
using BoletoBus.Infraestructure.Exceptions;
using System.Linq.Expressions;

namespace BoletoBus.Infraestructure.Repository
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        private readonly BusTicketContext context;
        public UsuarioRepository(BusTicketContext context) : base(context)
        {
            this.context = context;
        }

        public override async Task Save(Usuario entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException("La entidad Usuario no debe ser nula.");
            }
            //if (await base.Exists(cd => cd.IdBus == entity.IdBus))
            //{

            //}

            await base.Save(entity);
        }

        public override Task Update(Usuario entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException("La entidad Usuario no debe ser nula.");
            }

            return base.Update(entity);
        }

        public override Task Update(List<Usuario> entities)
        {
            if (entities is null)
            {
                throw new ArgumentNullException("La entidad Usuario no debe ser nula.");
            }

            if (!entities.Any())
            {
                throw new UsuarioDataException("Debe proporcionar por lo menos un numero de Usuario");
            }
            return base.Update(entities);
        }

        public override Task Save(List<Usuario> entities)
        {
            if (entities is null)
            {
                throw new ArgumentNullException("La entidad Usuario no debe ser nula.");
            }

            if (!entities.Any())
            {
                throw new UsuarioDataException("Debe proporcionar por lo menos un numero de Usuario");
            }
            return base.Save(entities);
        }

        public override Task<List<Usuario>> GetAll(Expression<Func<Usuario, bool>> filter)
        {
            return base.GetAll(filter);
        }

        public override Task<Usuario> Get(int Id)
        {
            return base.Get(Id);
        }

        public List<Usuario> GetUsuario()
        {
            throw new NotImplementedException();
        }
    }
}
