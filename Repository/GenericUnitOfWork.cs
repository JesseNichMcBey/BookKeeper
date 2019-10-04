using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookKeeper.Repository
{
    public class GenericUnitOfWork:IDisposable
    {
        //* private //*CONNECTION STRING NAME DBEntity DBEntity = new CONNECTIONSTRING NAME();
        public IRepository<Tbl_EntityType> GetRepositoryInstance<Tbl_EntityType>() where Tbl_EntityType: class
        {
            return new GenericRepository<Tbl_EntityType>(DBEntity);
        }

        public void SaveChanges()
        {
            DBEntity.SaveChanges();
        }

        protected virtual Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if(disposing)
                {
                    DBEntity.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool disposed = false;
    }
}