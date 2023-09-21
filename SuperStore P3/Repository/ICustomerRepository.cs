using Models;

namespace EcoPower_Logistics.Repository
{
    public interface ICustomerRepository: IgenericRepository<Customer>
    {
        Customer GetMostRecentCustomer();
    }
}
