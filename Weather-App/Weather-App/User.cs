using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Weather_App
{
    public class User
    {
        public int UserID { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public User() { }

        public User(string login, string email, string password)
        {
            Login = login;
            Email = email;
            Password = password;
        }

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public async static Task AddUser(User user)
        {
            using (var db = new UserContext())
            {
                db.Users.Add(user);
                await db.SaveChangesAsync();
            }
        }

        public static User SignIn(User user)
        {
            using (var db = new UserContext())
            {
                User user1 = (from dbuser in db.Users where dbuser.Login == user.Login select dbuser).FirstOrDefault();
                if (user1 != null)
                {
                    if (user1.Password == user.Password)
                        return user1;
                    else
                    {

                    }
                }
                return null;
            }           
        }
    }

    public class UserContext: DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
