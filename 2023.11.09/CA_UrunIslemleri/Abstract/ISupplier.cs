using CA_UrunIslemleri.Concrete;

namespace CA_UrunIslemleri.Abstract
{
    public interface ISupplier
    {
        //Create
        void Create(Supplier supplier);

        //Read
        void GetSupplierList();

        //Update
        void Update(Supplier updatedSupplier);

        //Delete
        void Delete(int id);

        //Get By Id
        Supplier GetById(int id);

        //Search
        Supplier SearchSupplier(string value);

        //Total Supplier Count
        int TotalSupplier();
    }
}
