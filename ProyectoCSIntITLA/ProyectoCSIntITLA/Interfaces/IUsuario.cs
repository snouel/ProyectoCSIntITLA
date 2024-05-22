

using DBBoletoBus.Domain.Entities;

namespace DBBoletoBus.Domain.Interfaces
{
    public interface IUsuario
    {
        Task Save(Usuario usuario);
        Task Save(List<Usuario> usuarios);
        Task Update(Usuario usuario);
        Task<Usuario> Get(int idUsuario);
        Task<List<Usuario>> GetAll();
    }
}
