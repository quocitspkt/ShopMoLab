using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMoLap.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private ShopMoLapDbContext dbContext;

        public ShopMoLapDbContext Init()
        {
            return dbContext ?? (dbContext = new ShopMoLapDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
