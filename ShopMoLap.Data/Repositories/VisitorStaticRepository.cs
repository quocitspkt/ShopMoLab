using ShopMoLap.Data.Infrastructure;
using ShopMoLap.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMoLap.Data.Repositories
{
    public interface IVisitorStaticRepository : IRepository<VisitorStatistic>
    {

    }
    public class VisitorStaticRepository : RepositoryBase<VisitorStatistic>, IVisitorStaticRepository
    {
        public VisitorStaticRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
