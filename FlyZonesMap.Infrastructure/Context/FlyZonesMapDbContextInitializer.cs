using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyZonesMap.Infrastructure.Context
{
    public class FlyZonesMapDbContextInitializer : DropCreateDatabaseIfModelChanges<FlyZonesMapDbContext>
    {
        protected override void Seed(FlyZonesMapDbContext db)
        {

        }
    }
}
