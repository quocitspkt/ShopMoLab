using Microsoft.AspNet.Identity.EntityFramework;
using ShopMoLap.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMoLap.Data
{
    class ShopMoLapDbContext: IdentityDbContext<ApplicationUser>
    {
        public ShopMoLapDbContext() : base("ShopMoLapConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public static ShopMoLapDbContext Create()
        {
            return new ShopMoLapDbContext();
        }
    }
}
