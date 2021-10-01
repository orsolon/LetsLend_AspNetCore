using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsLend.Models
{
    public interface IUserRepository
    {
        IQueryable<Borrower> Users { get; }
        void AddBorrower(Borrower user);
        void UpdateBorrower(Borrower user);
        void RemoveBorrower(Borrower user);
    }
}

