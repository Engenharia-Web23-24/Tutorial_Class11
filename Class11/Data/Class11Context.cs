using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Class11.Models;

namespace Class11.Data
{
    public class Class11Context : DbContext
    {
        public Class11Context (DbContextOptions<Class11Context> options)
            : base(options)
        {
        }

        public DbSet<Class11.Models.Person> Person { get; set; } = default!;
    }
}
