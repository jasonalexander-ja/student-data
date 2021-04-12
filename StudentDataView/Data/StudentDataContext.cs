using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using StudentDataView.Models;

namespace StudentDataView.Data
{
    public class StudentDataContext : DbContext
    {
        public StudentDataContext(DbContextOptions<StudentDataContext> options)
            : base(options)
        {
        }
        public DbSet<StudentDataModel> Students { get; set; }
        public DbSet<ContactDataModel> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentDataModel>().ToTable("StudentDataModel");
            modelBuilder.Entity<ContactDataModel>().ToTable("ContactDataModel");

            modelBuilder.Entity<ContactDataModel>()
                .HasOne(contact => contact.Student)
                .WithMany(student => student.Contacts)
                .HasForeignKey(contact => contact.StudentDataModelID);
        }
    }
}
