using LoginMVCCoreApp.Models;

namespace LoginMVCCoreApp.Services
{
    public class UserService
    {
        public static UserService _userService;
        public static List<User> _user = new List<User>();

        private UserService()
        {
            _user.Add(new User { Id = 1, Name = "Gautam",Password="Gautam",Address="Varanasi"});
            _user.Add(new User { Id = 2, Name = "Manjunath",Password="Manjunath",Address="HYD"});
        }
        public static UserService GetInstance()
        {
            if (_userService == null)
            {
                _userService=new UserService();
            }
            return _userService;
        }
        public List<User> GetAllUsers()
        {
            return _user;
        }
        public User GetByName(string name)
        {
            return _user.First(e => e.Name ==name);
        }
        public void Add(User user)
        {
            _user.Add(user);
        }
    }
}