using CleanArchitecture.Application.Contracts.Persistence;
using CleanArchitecture.Domain;
using CleanArchitecture.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class MaestraRepository : RepositoryBase<Maestra>, IMaestraRepository
    {
        public MaestraRepository(StreamerDbContext context) : base(context)
        {
        }
    }
}
