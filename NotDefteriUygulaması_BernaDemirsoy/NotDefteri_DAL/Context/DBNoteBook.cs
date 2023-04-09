using NotDefteri_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDefteri_DAL.Context
{
    internal class DBNoteBook:DbContext
    {
        public DBNoteBook():base("Server=LAPTOP-5JQ1KEF4;Database=DB_Notebook01;Trusted_Connection=True;")
        {

        }
        public DbSet<Note> Notes { get; set; }
        public DbSet<User> Users { get; set; }
       

        private void FixEfProviderServicesProblem()
        {
            // The Entity Framework provider type 'System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer'
            // for the 'System.Data.SqlClient' ADO.NET provider could not be loaded. 
            // Make sure the provider assembly is available to the running application. 
            // See http://go.microsoft.com/fwlink/?LinkId=260882 for more information.
            var instance = SqlProviderServices.Instance;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //User
            modelBuilder.Entity<User>().HasKey(u => u.UserID);
            modelBuilder.Entity<User>().Property(a => a.UserName).HasMaxLength(15);
            modelBuilder.Entity<User>().Property(a => a.Password).HasMaxLength(10);

            //Notes

            modelBuilder.Entity<Note>().HasKey(a => a.NoteID);
            modelBuilder.Entity<Note>().Property(a => a.NoteBody).HasColumnType("ntext");
            modelBuilder.Entity<Note>().Property(a => a.NoteHeader).HasColumnType("nvarchar").HasMaxLength(100);

            //Relationships

            modelBuilder.Entity<Note>().HasRequired(a => a.User).WithMany(n => n.Notes).HasForeignKey(a => a.UserID);

            
        }
    }
}
