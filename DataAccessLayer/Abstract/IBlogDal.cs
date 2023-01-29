using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal:IGenericDal<Blog>
    {
        ////4 ana metodu tanımla generic yaptık hepsini sildik:IGenericDal
        //List<Blog> ListAllBlog();
        //void AddBlog(Blog blog);
        //void DeleteBlog(Blog blog);
        //void UpdateBlog(Blog blog);
        //Blog GetById(int id);//id ye göre getir.
    }
}
