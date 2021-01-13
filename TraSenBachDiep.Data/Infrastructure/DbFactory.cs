using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraSenBachDiep.Data.Infrastructure
{
    public class DbFactory : Disposeable, IDbFactory
    {
       private TraSenBachDiepDbContext dbContext;
        public TraSenBachDiepDbContext Init()
        {
            return dbContext ?? (dbContext = new TraSenBachDiepDbContext());
        }
        protected override void DisposeCore()
        {
            if(dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}
