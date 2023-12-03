using CA_UrunIslemleri.Concrete;

namespace CA_UrunIslemleri.Abstract
{
    public interface IAppUser
    {
        //Create
        void Create();

        //Read
        void GetAppUserList();

        //Update
        void Update();

        //Delete
        void Delete();

        //Get By Id
        AppUser GetById();

        //Search
        AppUser SearchAppUser();

        //Total AppUser Count
        int TotalAppUser();
    }
}
