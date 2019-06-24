using <%= nomeProj %>.domain.domain.Interfaces;
using <%= nomeProj %>.domain.domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace <%= nomeProj %>.infra.Data.MSSQL.Repositories
{
    public class LivrosRepository : GenericRepository<Livros>, ILivrosRepository
    {
        public LivrosRepository(Context.Context context) : base (context)
        {
        }
    }
}
