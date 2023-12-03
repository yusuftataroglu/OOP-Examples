using CA_UrunIslemleri.Concrete;

namespace CA_UrunIslemleri.Abstract
{
    public interface ICustomer
    {
        //Create
        void Create(Customer customer);

        //Read
        void GetCustomerList();

        //Update
        void Update(Customer updatedCustomer);

        //Delete
        void Delete(int id);

        //Get By Id
        Customer GetById(int id);

        //Search
        Customer SearchCustomer(string value);

        //Total Customer Count
        int TotalCustomer();
    }
}
