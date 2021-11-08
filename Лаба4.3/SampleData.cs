using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop
{
    public class SampleData
    {
        public static void Initialize(AppDbContext context)
        {
            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new User
                    {
                        Surname = "Иванов",
                        Name = "Иван",
                        Gender = 'м',
                        YearOfBirth = new DateTime(2000, 11, 10)

                    }
                );
                context.SaveChanges();
            }
        }
    }
}
