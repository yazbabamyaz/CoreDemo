using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class BlogManager : IBlogService
	{
		IBlogDal _blogDal;

		public BlogManager(IBlogDal blogDal)
		{
			_blogDal = blogDal;
		}

		public void AddBlog(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void DeleteBlog(Blog blog)
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetAllBlogs()
		{
			return _blogDal.GetAll();
		}

		public List<Blog> GetBlogListWithCategory()
		{
			return _blogDal.GetListWithCategory();//dal katmanındaki metodu çalıştır.
		}

		public Blog GetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetBlogById(int id)
		{
			return _blogDal.GetAll(c=>c.BlogId == id);
		}

		public void UpdateBlog(Blog blog)
		{
			throw new NotImplementedException();
		}
	}
}
