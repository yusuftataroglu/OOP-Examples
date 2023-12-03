using CA_UrunIslemleri.Abstract;
using CA_UrunIslemleri.Data;
using CA_UrunIslemleri.Utils;

namespace CA_UrunIslemleri.Concrete
{
    public class CustomerConcrete
    {
        public void Create(Customer customer)
        {
            CustomerData.CustomerList.Add(customer);
            //Customer.CreatedDate = BaseClass.CreateDate();
            Message.SuccessMessage("*****Musteri eklendi.*****");
        }


        public void Delete(int id)
        {
            foreach (Customer item in CustomerData.CustomerList)
            {
                if (item.ID == id)
                {
                    CustomerData.CustomerList.Remove(item);
                    Message.SuccessMessage("*****Kategori silindi.*****");
                    break;
                }
                else
                {
                    Message.InfoMessage("-----Boyle bir musteri bulunamadı.-----");
                }
            }
            
        }

        public void GetCustomerList()
        {
            Console.WriteLine("------Customer List------");
            foreach (Customer customer in CustomerData.CustomerList)
            {
                Console.WriteLine(customer.ToString());
            }
        }

        public Customer GetById(int id)
        {
            foreach (Customer customer in CustomerData.CustomerList)
            {
                if (customer.ID == id)
                {
                    return customer;
                }
            }
            Message.InfoMessage("-----Musteri bulunamadi.-----");
            return null;
        }

        public Customer SearchCustomer(string companyName)
        {
            foreach (Customer customer in CustomerData.CustomerList)
            {
                if (customer.CompanyName == companyName)
                {
                    return customer;
                }
            }
            Message.InfoMessage("-----Musteri bulunamadi.-----");
            return null;
        }

        public int TotalCustomer()
        {
            return CustomerData.CustomerList.Count;
        }

        public void Update(Customer updatedCustomer)
        {
            foreach (Customer customer in CustomerData.CustomerList)
            {
                if (customer.ID == updatedCustomer.ID)
                {
                    customer.ID = updatedCustomer.ID;
                    customer.CompanyName = updatedCustomer.CompanyName;
                    customer.ContactName = updatedCustomer.ContactName;
                    customer.ContactTitle = updatedCustomer.ContactTitle;
                    customer.Phone = updatedCustomer.Phone;
                    customer.Country = updatedCustomer.Country;
                    //Customer.CreatedDate = BaseClass.CreateDate();
                    Message.SuccessMessage("*****Musteri bilgileri guncellendi.*****");
                    break;
                }
                else
                {
                    Message.InfoMessage("-----Musteri bulunamadi.-----");
                }
            }
            
        }
    }
}
