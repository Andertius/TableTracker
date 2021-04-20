using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using Newtonsoft.Json.Linq;

namespace AppServerC.BLL
{
    public class UserManager
    {
        private readonly PostgresContext _context;

        public UserManager(PostgresContext context)
        {
            _context = context;
        }

        public User Login(string json)
        {
            dynamic data = JObject.Parse(json);
            string userName = data.UserName;

            var user = _context.Users
                .Where(user => user.Username == userName)
                .FirstOrDefault();

            if (user is not null && user.Password == data.Password)
            {
                return user;
            }

            return null;
        }
    }
}
