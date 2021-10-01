using System.Collections.Generic;
using System.Linq;

namespace LetsLend.Models
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<Borrower> Users { get => _context.Users; }

        public void AddBorrower(Borrower user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void RemoveBorrower(Borrower user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }

        public void UpdateBorrower(Borrower user)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
        }
    }
}
