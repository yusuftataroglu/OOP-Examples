using CA_UrunIslemleri.Abstract;
using CA_UrunIslemleri.Concrete;
using CA_UrunIslemleri.Data;
using CA_UrunIslemleri.Utils;

namespace CA_TedarikciIslemleri.Concrete
{
    public class SupplierConcrete
    {
        public void Create(Supplier supplier)
        {
            SupplierData.SupplierList.Add(supplier);
            //Supplier.CreatedDate = BaseClass.CreateDate();
            Message.SuccessMessage("*****Tedarikci eklendi.*****");
        }


        public void Delete(int id)
        {
            foreach (Supplier item in SupplierData.SupplierList)
            {
                if (item.ID == id)
                {
                    SupplierData.SupplierList.Remove(item);
                    Message.SuccessMessage("*****Tedarikci silindi.*****");
                    break;
                }
                else
                {
                    Message.InfoMessage("-----Boyle bir tedarikci bulunamadı.-----");
                }
            }
            
        }

        public void GetSupplierList()
        {
            Console.WriteLine("------Supplier List------");
            foreach (Supplier supplier in SupplierData.SupplierList)
            {
                Console.WriteLine(supplier.ToString());
            }
        }

        public Supplier GetById(int id)
        {
            foreach (Supplier supplier in SupplierData.SupplierList)
            {
                if (supplier.ID == id)
                {
                    return supplier;
                }
            }
            Message.InfoMessage("-----Tedarikci bulunamadi.-----");
            return null;
        }

        public Supplier SearchSupplier(string contactName)
        {
            foreach (Supplier supplier in SupplierData.SupplierList)
            {
                if (supplier.ContactName == contactName)
                {
                    return supplier;
                }
            }
            Message.InfoMessage("-----Tedarikci bulunamadi.-----");
            return null;
        }

        public int TotalSupplier()
        {
            return SupplierData.SupplierList.Count;
        }

        public void Update(Supplier updatedSupplier)
        {
            foreach (Supplier supplier in SupplierData.SupplierList)
            {
                if (supplier.ID == updatedSupplier.ID)
                {
                    supplier.ID = updatedSupplier.ID;
                    supplier.ContactName = updatedSupplier.ContactName;
                    supplier.ContactTitle = updatedSupplier.ContactTitle;
                    supplier.CompanyName = updatedSupplier.CompanyName;
                    //Supplier.CreatedDate = BaseClass.CreateDate();
                    Message.SuccessMessage("*****Tedarikci bilgileri guncellendi.*****");
                    break;
                }
                else
                {
                    Message.InfoMessage("-----Tedarikci bulunamadi.-----");
                }
            }

        }

    }
}
