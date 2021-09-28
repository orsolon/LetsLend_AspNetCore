using System.Collections.Generic;

namespace LetsLend.Models
{
    public class UserRepository
    {
        private static List<Borrower> users = new List<Borrower>();

        public static IEnumerable<Borrower> Users { get => users; }

        public static void AddUser(Borrower user)
        {
            users.Add(user);
        }
    }
}
