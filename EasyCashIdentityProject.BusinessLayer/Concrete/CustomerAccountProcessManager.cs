using EasyCashIdentityProject.BusinessLayer.Abstract;
using EasyCashIdentityProject.DataAccessLayer.Abstracts;
using EasyCashIdentityProject.EntityLayer.Concrete;

namespace EasyCashIdentityProject.BusinessLayer.Concrete
{
    public class CustomerAccountProcessManager : GenericManager<CustomerAccountProcess>, ICustomerAccountProcessService
    {
        public CustomerAccountProcessManager(ICustomerAccountProcessDal customerAccountDal) : base(customerAccountDal)
        {
        }
    }
}
