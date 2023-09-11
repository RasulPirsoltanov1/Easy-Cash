using EasyCashIdentityProject.BusinessLayer.Abstract;
using EasyCashIdentityProject.DataAccessLayer.Abstracts;
using EasyCashIdentityProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.Concrete
{
    public class CustomerAccountManager :GenericManager<CustomerAccount>, ICustomerAccountService
    {
        public CustomerAccountManager(ICustomerAccountDal customerAccountDal) : base(customerAccountDal)
        {
        }
    }
}
