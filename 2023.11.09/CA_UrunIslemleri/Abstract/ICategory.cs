using CA_UrunIslemleri.Concrete;

namespace CA_UrunIslemleri.Abstract
{
    public interface ICategory
    {
        //Create
        void Create();

        //Read
        void GetCategoryList();

        //Update
        void Update();

        //Delete
        void Delete();

        //Get By Id
        Category GetById();

        //Search
        Category SearchCategory();

        //Total Category Count
        int TotalCategory();


    }
}
