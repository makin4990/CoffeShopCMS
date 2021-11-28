using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CustomerVerifyManager:ICustomerVerifyService
    {
        public bool IsVerified(Customer customer)
        {
            return true;
        }
    }
}
