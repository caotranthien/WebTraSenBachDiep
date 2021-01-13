using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraSenBachDiep.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private TraSenBachDiepDbContext dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }
        public TraSenBachDiepDbContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }

        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}
