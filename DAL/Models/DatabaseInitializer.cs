using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            GetUsers().ForEach(u => context.Users.Add(u));
            var users = context.Users.ToList();
            users.ForEach(p => context.Cards.Add(p.Card));
        }
        private static List<User> GetUsers()
        {
            var users = new List<User> {
                new User
                {
                    UserId = 1,
                    Firstname = "Julien",
                    Lastname = "Favre",
                    Username = "favju",
                    Card = new Card {}
                },
            };
            return users;
        }
    }
}
