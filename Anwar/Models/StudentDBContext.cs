using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anwar.Models
{
    public class StudentDBContext : DbContext
    {

        public StudentDBContext(DbContextOptions<StudentDBContext> options) : base(options)
        {

        }
        public DbSet<Student> students{ get; set; }

        public DbSet<LiveData> liveDatas { get; set; }

        public DbSet<Results> results { get; set; }
    }
}


