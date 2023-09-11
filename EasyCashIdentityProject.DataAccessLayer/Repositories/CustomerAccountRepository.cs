using EasyCashIdentityProject.DataAccessLayer.Abstracts;
using EasyCashIdentityProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.DataAccessLayer.Repositories
{
    public class CustomerAccountRepository:GenericRepository<CustomerAccount>, ICustomerAccountDal
    {
    }
}
