using LoginMVCCoreApp.Models;

namespace LoginMVCCoreApp.ViewModel
{
    public class UsersVM
    {
        public User? User {get;set;}
        public List<User>? Users { get; set; }
    }
}