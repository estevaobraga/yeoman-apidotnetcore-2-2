using <%= nomeProj %>.domain.domain.Interfaces;
using <%= nomeProj %>.domain.domain.Models;

namespace <%= nomeProj %>.infra.Data.MSSQL.Repositories
{
    public class UsuarioRepository : GenericRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(Context.Context context) : base (context)
        {
        }
    }
}
