using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookKeeper.Repository
{
    public class GenericRepository<Tbl_Entity> : IRepository <Tbl_Entity> where Tbl_Entity:class
    {
        DbSet<> 
    }
}