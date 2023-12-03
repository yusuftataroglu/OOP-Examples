using CA_UrunIslemleri.Abstract;

namespace CA_UrunIslemleri.Concrete
{
    public class AppUser : BaseClass
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"User ID: {ID} Firstname: {FirstName} Lastname: {LastName} Username: {Username} Password: {Password} Email: {Email} Created Date: {CreatedDate}\n";
        }
    }
}
