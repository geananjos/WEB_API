using OdontoSys.Domain.Core.Interfaces.Repositories;
using OdontoSys.Domain.Entities;

namespace OdontoSys.Infrastructure.Data.Repositories
{
    public class PacienteRepository : RepositoryBase<Paciente>, IPacienteRepository
    {
        private readonly SqlContext _sqlContext;

        public PacienteRepository(SqlContext sqlcontext)
            : base(sqlcontext)
        {
            _sqlContext = sqlcontext;
        }
    }
}