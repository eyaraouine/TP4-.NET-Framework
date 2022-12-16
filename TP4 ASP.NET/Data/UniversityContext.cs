using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace TP4_ASP.NET.Models.Data
{
    public class UniversityContext : DbContext
    {
        public DbSet<Student> Student { get; set; }
        public static UniversityContext _context;

        private UniversityContext(DbContextOptions o) : base(o) { }

        private static UniversityContext Instantiate_UniversityContext()
        {
            Debug.WriteLine("We enter the Instantiate_UniversityContext method");
            var optionsBuilder = new DbContextOptionsBuilder<UniversityContext>();
            optionsBuilder.UseSqlite(@"Data Source =C:\Users\user\Downloads\2022 GL3 .NET Framework TP4 - SQLite database.db");
            return new UniversityContext(optionsBuilder.Options);

        }

        public static UniversityContext Context
        {
            get
            {
                if (_context == null)
                    _context = Instantiate_UniversityContext();
                return _context;
            }
        }

    }
}
