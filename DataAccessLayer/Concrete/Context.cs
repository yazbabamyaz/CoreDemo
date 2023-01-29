using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=CoreBlogDb;integrated security=True;");
        }
        //Burada referans verme işlemi yapalım dbsetten önce.Data access layer da dependencies e right click add project referance
        //Entity Layer katmanını seç. Business a da aynı işlemleri yap dataaccess ve entity i seç.
        //aynı işlemi CoreDemo da da yap yani Presantion katmanı (UI). 3 ünü seç. data-business-entity.
        //context sınıfına ait dbsetleri hazırladık.

        //Db tabloları(Abouts-çoğul) ile entity classları(About-tekil) arasında ilişki kurduk
        public DbSet<About> Abouts  { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set;}
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }

    }
}
