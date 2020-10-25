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
                User user1 = (from dbuser in db.Users where dbuser.Login == user.Login && dbuser.Password == user.Password select dbuser).FirstOrDefault();
                if (user1 != null)
                    return user1;
                return null;
            }
        }
        public static string Encode(string password)
        {
            byte[] passwordBytes = System.Text.Encoding.Unicode.GetBytes(password);
            System.Security.Cryptography.HashAlgorithm hashAlgo = new System.Security.Cryptography.SHA256Managed();
            byte[] hash = hashAlgo.ComputeHash(passwordBytes);
            return System.Text.Encoding.Unicode.GetString(hash);
        }

        public static bool[] IsUserUnique(User user)
        {
            bool[] unique = new bool[2];
            using (var db = new UserContext())
            {
                User user1 = (from dbuser in db.Users where dbuser.Login == user.Login select dbuser).FirstOrDefault();
                if (user1 != null)
                    unique[0] = false;
                else
                    unique[0] = true;
                user1 = (from dbuser in db.Users where dbuser.Email == user.Email select dbuser).FirstOrDefault();
                if (user1 != null)
                    unique[1] = false;
                else
                    unique[1] = true;
            }
            return unique;
        }
    }

    public class UserContext: DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
