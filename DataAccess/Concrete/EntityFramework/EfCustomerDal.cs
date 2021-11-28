using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal:RepositoryBase<Customer>, ICustomerDal
    {
        public EfCustomerDal(CoffeShopDbContext dbContext) : base(dbContext)
        {
        }
    }
}
